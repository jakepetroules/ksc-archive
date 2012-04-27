#ifndef RESOURCE_H
#define RESOURCE_H

#include <QObject>
#include <QUuid>
#include "database.h"

class User;
class Group;
class PermissionSet;

class Resource : public QObject
{
    Q_OBJECT
public:
    explicit Resource(QObject *parent = 0);
    virtual ~Resource();
    User* owner(const Database &db) const;
    void setOwner(const QString &userName);
    Group* group(const Database &db) const;
    void setGroup(const QString &groupName);
    PermissionSet* permissions() const;
    QUuid code() const;
    void setCode(QUuid code);
    QString resourceName() const;
    void setResourceName(const QString &name);

private:
    class Private;
    Private *d;
};

#endif // RESOURCE_H
