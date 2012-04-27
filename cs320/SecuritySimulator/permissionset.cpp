#include "permissionset.h"

class PermissionSet::Private
{
public:
    Private()
    {
        flags = PermissionSet::None;
    }

    PermissionSet::PermissionFlags flags;
};

PermissionSet::PermissionSet(QObject *parent) :
    QObject(parent)
{
    d = new Private();
}

PermissionSet::~PermissionSet()
{
    delete d;
}

PermissionSet::PermissionFlags PermissionSet::permissions() const
{
    return d->flags;
}

void PermissionSet::setPermissions(PermissionFlags flags)
{
    d->flags = flags;
}

bool PermissionSet::isFlagSet(PermissionFlags flag) const
{
    return (d->flags & flag) == flag;
}

void PermissionSet::setPermissionFlags(PermissionFlags flag, bool on)
{
    if (on)
    {
        d->flags = d->flags | flag;
    }
    else
    {
        d->flags = d->flags & ~flag;
    }
}

void PermissionSet::setFromString(const QString &str)
{
    if (str.size() != 6)
        return;

    setPermissions(None);

    if (str.at(0) != '-')
        setPermissionFlags(OwnerRead);

    if (str.at(1) != '-')
        setPermissionFlags(OwnerWrite);

    if (str.at(2) != '-')
        setPermissionFlags(GroupRead);

    if (str.at(3) != '-')
        setPermissionFlags(GroupWrite);

    if (str.at(4) != '-')
        setPermissionFlags(WorldRead);

    if (str.at(5) != '-')
        setPermissionFlags(WorldWrite);
}

QString PermissionSet::toString() const
{
    QString permissionsString;
    permissionsString += isFlagSet(OwnerRead) ? "r" : "-";
    permissionsString += isFlagSet(OwnerWrite) ? "w" : "-";
    permissionsString += isFlagSet(GroupRead) ? "r" : "-";
    permissionsString += isFlagSet(GroupWrite) ? "w" : "-";
    permissionsString += isFlagSet(WorldRead) ? "r" : "-";
    permissionsString += isFlagSet(WorldWrite) ? "w" : "-";
    return permissionsString;
}
