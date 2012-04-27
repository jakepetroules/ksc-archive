#include "chowncommand.h"
#include "resource.h"
#include "user.h"
#include "group.h"

ChownCommand::ChownCommand(QStringList args, QObject *parent) :
    Command(args, parent)
{
    setName(commandName());
}

bool ChownCommand::execute(Environment &env)
{
    if (!env.user()->isRoot())
    {
        env.insufficientPermissions();
        return false;
    }

    if (args().size() != 2)
    {
        env.invalidCommandFormat();
        return false;
    }

    QString args1 = args().first();
    QStringList parts = args1.split(":");
    QString newOwner = parts.size() >= 1 ? parts.at(0) : "";
    QString newGroup = parts.size() >= 2 ? parts.at(1) : "";
    QString resourceName = args().at(1);

    Resource *res = env.database().getResource(resourceName);
    if (!res)
    {
        env.objectDoesNotExist(resourceName);
        return false;
    }

    if (!newOwner.isEmpty())
    {
        User *user = env.database().getUser(newOwner);
        if (!user)
        {
            env.objectDoesNotExist(newOwner);
            return false;
        }

        res->setOwner(user->userName());
    }

    if (!newGroup.isEmpty())
    {
        Group *group = env.database().getGroup(newGroup);
        if (!group)
        {
            env.objectDoesNotExist(newGroup);
            return false;
        }

        res->setGroup(group->groupName());
    }

    return true;
}

QString ChownCommand::commandName()
{
    return "chown";
}
