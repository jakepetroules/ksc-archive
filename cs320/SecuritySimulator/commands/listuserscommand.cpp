#include "listuserscommand.h"
#include "user.h"
#include "group.h"

ListUsersCommand::ListUsersCommand(QStringList args, QObject *parent) :
    Command(args, parent)
{
    setName(commandName());
}

bool ListUsersCommand::execute(Environment &env)
{
    bool longFormat = false;
    if (args().size() == 1 && args().at(0) == "-l")
        longFormat = true;

    foreach (User *user, env.database().allUsers())
    {
        QString line;
        if (longFormat)
        {
            line += user->userName();

            QStringList groups;
            foreach (Group *g, user->groups())
            {
                groups += g->groupName();
            }

            if (groups.size() > 0)
            {
                line += QString(" (%1)").arg(groups.join(", "));
            }

            line += QString(" - password last changed %1").arg(user->lastPasswordChange().toUTC().toString(Qt::ISODate));
        }
        else
        {
            line += user->userName();
        }

        env.display(line);
    }

    return true;
}

QString ListUsersCommand::commandName()
{
    return "lsusers";
}
