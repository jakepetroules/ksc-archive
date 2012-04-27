#include "authenticator.h"
#include "user.h"
#include "group.h"
#include "resource.h"
#include "permissionset.h"
#include "environment.h"

class Authenticator::Private
{
public:
    Environment *env;
};

Authenticator::Authenticator(Environment *env, QObject *parent) :
    QObject(parent)
{
    d = new Private();
    d->env = env;
}

Authenticator::~Authenticator()
{
    delete d;
}

bool Authenticator::validate(const QString &username, const QString &password)
{
    foreach (User *user, d->env->database().allUsers())
    {
        if (user->userName() == username && user->password() == password)
        {
            return true;
        }
    }

    return false;
}

bool Authenticator::canChangeOwner(const User *user, const Resource *resource)
{
    Q_UNUSED(resource);
    return user->isRoot();
}

bool Authenticator::canChangePermissions(const User *user, const Resource *resource)
{
    // Can change permissions if root or file owner
    return user->isRoot() || user->userName() == resource->owner(d->env->database())->userName();
}

bool Authenticator::hasReadPermission(const User *user, const Resource *resource)
{
    // root can do anything
    if (user->isRoot())
        return true;

    // user owns the object
    if (user->userName() == resource->owner(d->env->database())->userName() && resource->permissions()->isFlagSet(PermissionSet::OwnerRead))
        return true;

    // user is a member of the object's group
    foreach (User *user, resource->group(d->env->database())->users())
    {
        if (user->userName() == user->userName() && resource->permissions()->isFlagSet(PermissionSet::GroupRead))
        {
            return true;
        }
    }

    // is the read by anyone flag set?
    if (resource->permissions()->isFlagSet(PermissionSet::WorldRead))
        return true;

    return false;
}

bool Authenticator::hasWritePermission(const User *user, const Resource *resource)
{
    // root can do anything
    if (user->isRoot())
        return true;

    // user owns the object
    if (user->userName() == resource->owner(d->env->database())->userName() && resource->permissions()->isFlagSet(PermissionSet::OwnerWrite))
        return true;

    // user is a member of the object's group
    foreach (User *user, resource->group(d->env->database())->users())
    {
        if (user->userName() == user->userName() && resource->permissions()->isFlagSet(PermissionSet::GroupWrite))
        {
            return true;
        }
    }

    // is the write by anyone flag set?
    if (resource->permissions()->isFlagSet(PermissionSet::WorldWrite))
        return true;

    return false;
}
