#include "listgroupscommand.h"
#include "group.h"

ListGroupsCommand::ListGroupsCommand(QStringList args, QObject *parent) :
    Command(args, parent)
{
    setName(commandName());
}

bool ListGroupsCommand::execute(Environment &env)
{
    foreach (Group *group, env.database().allGroups())
    {
        env.display(group->groupName());
    }

    return true;
}

QString ListGroupsCommand::commandName()
{
    return "lsgroups";
}
