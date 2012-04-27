#include "chmodcommand.h"
#include "user.h"
#include "resource.h"
#include "group.h"
#include "permissionset.h"

ChmodCommand::ChmodCommand(QStringList args, QObject *parent) :
    Command(args, parent)
{
    setName(commandName());
}

bool ChmodCommand::execute(Environment &env)
{
    if (args().size() != 2)
    {
        env.invalidCommandFormat();
        return false;
    }

    QString newPermissions = args().first();
    QString resourceName = args().at(1);
    Resource *resource = env.database().getResource(resourceName);
    if (!resource)
    {
        env.objectDoesNotExist(resourceName);
        return false;
    }

    if (!env.user()->isRoot() && env.user()->userName() != resource->owner(env.database())->userName())
    {
        env.insufficientPermissions();
        return false;
    }

    resource->permissions()->setFromString(newPermissions);
    return true;
}

QString ChmodCommand::commandName()
{
    return "chmod";
}
