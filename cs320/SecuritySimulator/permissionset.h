#ifndef PERMISSIONSET_H
#define PERMISSIONSET_H

#include <QObject>

class PermissionSet : public QObject
{
    Q_OBJECT

public:
    enum PermissionFlags
    {
        None = 0,
        OwnerRead = 1,
        OwnerWrite = 2,
        GroupRead = 4,
        GroupWrite = 8,
        WorldRead = 16,
        WorldWrite = 32
    };

    explicit PermissionSet(QObject *parent = 0);
    virtual ~PermissionSet();
    PermissionFlags permissions() const;
    void setPermissions(PermissionFlags flags);
    bool isFlagSet(PermissionFlags flag) const;
    void setPermissionFlags(PermissionFlags flag, bool on = true);
    void setFromString(const QString &str);
    QString toString() const;

private:
    class Private;
    Private *d;
};

inline PermissionSet::PermissionFlags operator|(PermissionSet::PermissionFlags a, PermissionSet::PermissionFlags b)
{
    return static_cast<PermissionSet::PermissionFlags>(static_cast<int>(a) | static_cast<int>(b));
}

inline PermissionSet::PermissionFlags operator&(PermissionSet::PermissionFlags a, PermissionSet::PermissionFlags b)
{
    return static_cast<PermissionSet::PermissionFlags>(static_cast<int>(a) & static_cast<int>(b));
}

inline PermissionSet::PermissionFlags operator~(PermissionSet::PermissionFlags a)
{
    return static_cast<PermissionSet::PermissionFlags>(static_cast<int>(~a));
}

#endif // PERMISSIONSET_H
