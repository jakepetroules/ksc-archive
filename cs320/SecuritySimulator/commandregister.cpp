#include "commandregister.h"
#include <QtCore>
#include "command.h"
#include "commands/addgroupcommand.h"
#include "commands/addusercommand.h"
#include "commands/chmodcommand.h"
#include "commands/chowncommand.h"
#include "commands/identitycommand.h"
#include "commands/listgroupscommand.h"
#include "commands/listresourcescommand.h"
#include "commands/listuserscommand.h"
#include "commands/modgroupcommand.h"
#include "commands/passwordchangecommand.h"
#include "commands/removecommand.h"
#include "commands/removegroupcommand.h"
#include "commands/removeusercommand.h"
#include "commands/touchcommand.h"

class CommandRegister::Private
{
public:
    QMap<QString, Command*> commandCache;
};

CommandRegister::CommandRegister()
{
    d = new Private();
    d->commandCache.insert(AddGroupCommand::commandName(), new AddGroupCommand());
    d->commandCache.insert(AddUserCommand::commandName(), new AddUserCommand());
    d->commandCache.insert(ChmodCommand::commandName(), new ChmodCommand());
    d->commandCache.insert(ChownCommand::commandName(), new ChownCommand());
    d->commandCache.insert(IdentityCommand::commandName(), new IdentityCommand());
    d->commandCache.insert(ListGroupsCommand::commandName(), new ListGroupsCommand());
    d->commandCache.insert(ListResourcesCommand::commandName(), new ListResourcesCommand());
    d->commandCache.insert(ListUsersCommand::commandName(), new ListUsersCommand());
    d->commandCache.insert(ModGroupCommand::commandName(), new ModGroupCommand());
    d->commandCache.insert(PasswordChangeCommand::commandName(), new PasswordChangeCommand());
    d->commandCache.insert(RemoveCommand::commandName(), new RemoveCommand());
    d->commandCache.insert(RemoveGroupCommand::commandName(), new RemoveGroupCommand());
    d->commandCache.insert(RemoveUserCommand::commandName(), new RemoveUserCommand());
    d->commandCache.insert(TouchCommand::commandName(), new TouchCommand());
}

CommandRegister::~CommandRegister()
{
    delete d;
}

CommandRegister& CommandRegister::instance()
{
    static CommandRegister r;
    return r;
}

bool CommandRegister::contains(const QString &key)
{
    return d->commandCache.contains(key);
}

Command* CommandRegister::value(const QString &key)
{
    return d->commandCache.value(key);
}

QList<Command*> CommandRegister::values()
{
    QList<Command*> commands;
    QMapIterator<QString, Command*> i(d->commandCache);
    while (i.hasNext())
    {
        i.next();
        commands.append(i.value());
    }

    return commands;
}
