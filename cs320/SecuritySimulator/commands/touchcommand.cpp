#include "touchcommand.h"
#include "resource.h"
#include "user.h"
#include "group.h"

TouchCommand::TouchCommand(QStringList args, QObject *parent) :
    Command(args, parent)
{
    setName(commandName());
}

bool TouchCommand::execute(Environment &env)
{
    if (args().size() < 1)
    {
        env.invalidCommandFormat();
        return false;
    }

    foreach (QString res, args())
    {
        if (!env.database().getResource(res))
        {
            Resource *resource = new Resource();
            resource->setResourceName(res);
            resource->setOwner(env.user()->userName());

            Group *g = env.database().getGroup("staff");
            if (env.user()->groups().size() >= 1)
                g = env.user()->groups().first();

            resource->setGroup(g->groupName());
            env.database().addObject(resource);
        }
    }

    return true;
}

QString TouchCommand::commandName()
{
    return "touch";
}
