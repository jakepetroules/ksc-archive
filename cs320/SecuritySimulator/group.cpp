#include "group.h"
#include "user.h"

class Group::Private
{
public:
    QList<User*> users;
    QUuid code;
    QString name;
};

Group::Group(QObject *parent) :
    QObject(parent)
{
    d = new Private();
    d->code = QUuid::createUuid();
}

Group::~Group()
{
    delete d;
}

const QList<User*> Group::users() const
{
    return d->users;
}

void Group::addUser(User *user)
{
    d->users.append(user);
    user->addToGroup(this);
}

bool Group::removeUser(User *user)
{
    bool removed = d->users.removeOne(user);
    if (removed)
    {
        user->removeFromGroup(this);
    }

    return removed;
}

QUuid Group::code() const
{
    return d->code;
}

void Group::setCode(QUuid code)
{
    d->code = code;
}

QString Group::groupName() const
{
    return d->name;
}

void Group::setGroupName(const QString &name)
{
    d->name = name;
}
