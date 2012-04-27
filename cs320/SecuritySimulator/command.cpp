#include "command.h"
#include <QtCore>
#include "commandregister.h"

class Command::Private
{
public:
    QString name;
    QStringList args;
};

Command::Command(QStringList args, QObject *parent) :
    QObject(parent)
{
    d = new Private();
    d->args = args;
}

Command::~Command()
{
    delete d;
}

QString Command::name() const
{
    return d->name;
}

QStringList Command::args() const
{
    return d->args;
}

Command* Command::parse(const QString &string)
{
    QStringList list = string.split(" ", QString::SkipEmptyParts);
    if (list.size() < 1)
    {
        return NULL;
    }

    QString commandName = list.takeFirst();
    if (CommandRegister::instance().contains(commandName))
    {
        Command *cmd = CommandRegister::instance().value(commandName);
        cmd->d->args = list;
        return cmd;
    }

    return NULL;
}

void Command::setName(const QString &name)
{
    d->name = name;
}
