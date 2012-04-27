#include "securitysimulatorapplication.h"
#include "user.h"
#include "authenticator.h"
#include "command.h"
#include "database.h"
#include "resource.h"
#include "group.h"
#include "environment.h"
#include "commandregister.h"
#include <QtCore>

class SecuritySimulatorApplication::Private
{
public:
    Environment env;
};

SecuritySimulatorApplication::SecuritySimulatorApplication(int &argc, char **argv, int) :
    QCoreApplication(argc, argv)
{
    d = new Private();
    QTimer::singleShot(0, this, SLOT(run()));
}

SecuritySimulatorApplication::~SecuritySimulatorApplication()
{
    delete d;
}

void SecuritySimulatorApplication::run()
{
    d->env.database().load("secsim.db");
    attemptAuthentication();
    quit();
    d->env.database().save("secsim.db");
}

void SecuritySimulatorApplication::attemptAuthentication()
{
    QTextStream in(stdin);

    d->env.display("SecuritySimulator username: ", false);
    QString username = in.readLine();
    d->env.display("SecuritySimulator password: ", false);
    QString password = in.readLine();

    if (d->env.login(username, password))
    {
        d->env.display("Successfully authenticated.");
        enterCommandLoop();
    }
    else
    {
        d->env.display("Incorrect username or password.");
    }
}

void SecuritySimulatorApplication::enterCommandLoop()
{
    while (true)
    {
        if (!processCommand(d->env.prompt()))
            break;
    }
}

bool SecuritySimulatorApplication::processCommand(const QString &commandString)
{
    // Built-in commands for exiting
    if (commandString == "quit" || commandString == "exit" || commandString == "logout")
    {
        return false;
    }

    // Show commands
    if (commandString == "help")
    {
        foreach (Command *cmd, CommandRegister::instance().values())
        {
            d->env.display(cmd->name());
        }

        return true;
    }

    // Parse the command given to us
    Command *command = Command::parse(commandString);
    if (!command)
    {
        if (!commandString.isEmpty())
            d->env.display(commandString + ": unknown command.");

        return true;
    }

    // Execute it
    command->execute(d->env);

    return true;
}
