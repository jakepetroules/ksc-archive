#ifndef DATABASE_H
#define DATABASE_H

#include <QObject>

class User;
class Group;
class Resource;

class Database : public QObject
{
    Q_OBJECT
public:
    explicit Database(QObject *parent = 0);
    virtual ~Database();
    void load(const QString &fileName);
    void save(const QString &fileName);
    void addObject(User *user);
    void addObject(Group *group);
    void addObject(Resource *resource);
    void removeObject(User *user);
    void removeObject(Group *group);
    void removeObject(Resource *resource);
    const QList<User*> allUsers() const;
    User *getUser(const QString &userName) const;
    const QList<Group*> allGroups() const;
    Group *getGroup(const QString &groupName) const;
    const QList<Resource*> allResources() const;
    Resource *getResource(const QString &resourceName) const;

private:
    class Private;
    Private *d;
};

#endif // DATABASE_H
