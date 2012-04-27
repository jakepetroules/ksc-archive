#include "user.h"
#include "group.h"

class User::Private
{
public:
    QList<Group*> groups;
    QUuid code;
    QString userName;
    QString password;
    qint32 passwordChangeCeiling;
    QDateTime lastPasswordChange;
};

User::User(QObject *parent) :
    QObject(parent)
{
    d = new Private();
    d->code = QUuid::createUuid();
    d->passwordChangeCeiling = 0;
    d->lastPasswordChange = QDateTime::fromMSecsSinceEpoch(0);
}

User::~User()
{
    delete d;
}

const QList<Group*> User::groups() const
{
    return d->groups;
}

QUuid User::code() const
{
    return d->code;
}

void User::setCode(QUuid code)
{
    d->code = code;
}

QString User::userName() const
{
    return d->userName;
}

void User::setUserName(const QString &userName)
{
    d->userName = userName;
}

QString User::password() const
{
    return d->password;
}

void User::setPassword(const QString &password)
{
    d->password = password;
    d->lastPasswordChange = QDateTime::currentDateTimeUtc();
}

qint32 User::passwordChangeCeiling() const
{
    return d->passwordChangeCeiling;
}

void User::setPasswordChangeCeiling(qint32 passwordChangeCeiling)
{
    d->passwordChangeCeiling = passwordChangeCeiling;
}

QDateTime User::lastPasswordChange() const
{
    return d->lastPasswordChange;
}

bool User::isRoot() const
{
    return d->userName == "root";
}

void User::addToGroup(Group *group)
{
    d->groups.append(group);
}

bool User::removeFromGroup(Group *group)
{
    return d->groups.removeOne(group);
}

void User::setLastPasswordChange(const QDateTime &date)
{
    d->lastPasswordChange = date;
}
