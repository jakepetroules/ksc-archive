#include "modgroupcommand.h"
#include "group.h"
#include "user.h"

ModGroupCommand::ModGroupCommand(QStringList args, QObject *parent) :
    Command(args, parent)
{
    setName(commandName());
}

bool ModGroupCommand::execute(Environment &env)
{
    if (args().size() != 3)
    {
        env.invalidCommandFormat();
        return false;
    }

    if (!env.user()->isRoot())
    {
        env.insufficientPermissions();
        return false;
    }

    QString groupName = args().at(0);
    QString action = args().at(1);
    QString userName = args().at(2);

    Group *group = env.database().getGroup(groupName);
    if (!group)
    {
        env.objectDoesNotExist(groupName);
        return false;
    }

    User *user = env.database().getUser(userName);
    if (!user)
    {
        env.objectDoesNotExist(userName);
        return false;
    }

    bool contains = false;
    foreach (User *user, group->users())
    {
        if (user->userName() == userName)
        {
            contains = true;
            break;
        }
    }

    if (action == "add")
    {
        if (contains)
        {
            env.display(QString("%1 is already a member of %2; no action to take").arg(userName).arg(groupName));
            return false;
        }
        else
        {
            group->addUser(user);
        }
    }
    else if (action == "remove")
    {
        if (user->isRoot() && group->groupName() == "root")
        {
            env.display("The root user cannot be removed from the root group");
            return false;
        }

        if (!contains)
        {
            env.display(QString("%1 is not a member of %2; no action to take").arg(userName).arg(groupName));
            return false;
        }
        else
        {
            group->removeUser(user);
        }
    }
    else
    {
        env.display(QString("Unknown action '%1'").arg(action));
        return false;
    }

    return true;
}

QString ModGroupCommand::commandName()
{
    return "modgroup";
}
