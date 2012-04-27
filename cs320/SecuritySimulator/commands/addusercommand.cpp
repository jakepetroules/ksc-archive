#include "addusercommand.h"
#include "user.h"

AddUserCommand::AddUserCommand(QStringList args, QObject *parent)
    : Command(args, parent)
{
    setName(commandName());
}

bool AddUserCommand::execute(Environment &env)
{
    if (!env.user()->isRoot())
    {
        env.insufficientPermissions();
        return false;
    }

    if (args().size() != 1)
    {
        env.invalidCommandFormat();
        return false;
    }

    QString userName = args().first();
    if (!env.database().getUser(userName))
    {
        User *user = new User();
        user->setUserName(userName);
        env.database().addObject(user);
        env.display("Added user " + userName);
    }

    return true;
}

QString AddUserCommand::commandName()
{
    return "adduser";
}
