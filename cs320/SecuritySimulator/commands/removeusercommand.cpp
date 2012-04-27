#include "removeusercommand.h"
#include "user.h"

RemoveUserCommand::RemoveUserCommand(QStringList args, QObject *parent) :
    Command(args, parent)
{
    setName(commandName());
}

bool RemoveUserCommand::execute(Environment &env)
{
    if (args().size() != 1)
    {
        env.invalidCommandFormat();
        return false;
    }

    if (!env.user()->isRoot())
    {
        env.insufficientPermissions();
        return false;
    }

    QString userName = args().first();
    User *user = env.database().getUser(userName);
    if (!user)
    {
        env.objectDoesNotExist(userName);
        return false;
    }

    if (user->isRoot())
    {
        env.display("The root user cannot be removed.");
        return false;
    }

    env.database().removeObject(user);
    env.display("The user was removed.");
    return true;
}

QString RemoveUserCommand::commandName()
{
    return "rmuser";
}
