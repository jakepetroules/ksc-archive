#include "identitycommand.h"
#include "user.h"

IdentityCommand::IdentityCommand(QStringList args, QObject *parent) :
    Command(args, parent)
{
    setName(commandName());
}

bool IdentityCommand::execute(Environment &env)
{
    env.display(env.user()->userName());
    return true;
}

QString IdentityCommand::commandName()
{
    return "whoami";
}
