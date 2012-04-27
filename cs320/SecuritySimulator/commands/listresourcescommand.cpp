#include "listresourcescommand.h"
#include "resource.h"
#include "group.h"
#include "user.h"
#include "permissionset.h"

ListResourcesCommand::ListResourcesCommand(QStringList args, QObject *parent) :
    Command(args, parent)
{
    setName(commandName());
}

bool ListResourcesCommand::execute(Environment &env)
{
    bool longFormat = false;
    if (args().size() == 1 && args().at(0) == "-l")
        longFormat = true;

    foreach (Resource *res, env.database().allResources())
    {
        QString line;
        if (longFormat)
        {
            line += QString("%1 %2 %3 %4")
                    .arg(res->permissions()->toString())
                    .arg(res->owner(env.database())->userName())
                    .arg(res->group(env.database())->groupName())
                    .arg(res->resourceName());
        }
        else
        {
            line += res->resourceName();
        }

        env.display(line);
    }

    return true;
}

QString ListResourcesCommand::commandName()
{
    return "ls";
}
