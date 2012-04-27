#include "removecommand.h"

RemoveCommand::RemoveCommand(QStringList args, QObject *parent) :
    Command(args, parent)
{
    setName(commandName());
}

bool RemoveCommand::execute(Environment &env)
{
    if (args().size() != 1)
    {
        env.invalidCommandFormat();
        return false;
    }

    QString resourceName = args().first();
    Resource *resource = env.database().getResource(resourceName);
    if (!resource)
    {
        env.objectDoesNotExist(resourceName);
        return false;
    }

    if (!env.authenticator().hasWritePermission(env.user(), resource))
    {
        env.insufficientPermissions();
        return false;
    }

    env.database().removeObject(resource);
    env.display("Resource has been removed.");
    return true;
}

QString RemoveCommand::commandName()
{
    return "rm";
}
