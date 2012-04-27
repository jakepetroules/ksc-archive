#include "resource.h"
#include "user.h"
#include "group.h"
#include "permissionset.h"

class Resource::Private
{
public:
    QUuid code;
    QString name;
    QString owner;
    QString group;
    PermissionSet *permissions;
};

Resource::Resource(QObject *parent) :
    QObject(parent)
{
    d = new Private();
    d->code = QUuid::createUuid();
    d->permissions = new PermissionSet();
    d->permissions->setPermissionFlags(PermissionSet::OwnerRead | PermissionSet::OwnerWrite | PermissionSet::GroupRead);
}

Resource::~Resource()
{
    delete d;
}

#define EITHER(a, b) (a ? a : b)

User* Resource::owner(const Database &db) const
{
    return EITHER(db.getUser(d->name), db.getUser("root"));
}

void Resource::setOwner(const QString &userName)
{
    d->owner = userName;
}

Group* Resource::group(const Database &db) const
{
    return EITHER(db.getGroup(d->group), db.getGroup("staff"));
}

void Resource::setGroup(const QString &groupName)
{
    d->group = groupName;
}

PermissionSet* Resource::permissions() const
{
    return d->permissions;
}

QUuid Resource::code() const
{
    return d->code;
}

void Resource::setCode(QUuid code)
{
    d->code = code;
}

QString Resource::resourceName() const
{
    return d->name;
}

void Resource::setResourceName(const QString &name)
{
    d->name = name;
}
