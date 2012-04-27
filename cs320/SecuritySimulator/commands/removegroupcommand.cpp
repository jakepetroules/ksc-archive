#include "removegroupcommand.h"
#include "user.h"
#include "group.h"

RemoveGroupCommand::RemoveGroupCommand(QStringList args, QObject *parent) :
    Command(args, parent)
{
    setName(commandName());
}

bool RemoveGroupCommand::execute(Environment &env)
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

    QString groupName = args().first();
    Group *group = env.database().getGroup(groupName);
    if (!group)
    {
        env.objectDoesNotExist(groupName);
        return false;
    }

    if (group->groupName() == "root" || group->groupName() == "staff")
    {
        env.display("The root and staff groups cannot be removed.");
        return false;
    }

    foreach (User *user, group->users())
    {
        group->removeUser(user);
    }

    env.database().removeObject(group);
    env.display("The group was removed.");
    return true;
}

QString RemoveGroupCommand::commandName()
{
    return "rmgroup";
}
