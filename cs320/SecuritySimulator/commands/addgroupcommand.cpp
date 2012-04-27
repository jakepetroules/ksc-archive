#include "addgroupcommand.h"
#include "user.h"
#include "group.h"

AddGroupCommand::AddGroupCommand(QStringList args, QObject *parent) :
    Command(args, parent)
{
    setName(commandName());
}

bool AddGroupCommand::execute(Environment &env)
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

    QString groupName = args().first();
    if (!env.database().getGroup(groupName))
    {
        Group *group = new Group();
        group->setGroupName(groupName);
        env.database().addObject(group);
        env.display("Added group " + groupName);
    }

    return true;
}

QString AddGroupCommand::commandName()
{
    return "addgroup";
}
