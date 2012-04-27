#ifndef AUTHENTICATOR_H
#define AUTHENTICATOR_H

#include <QObject>

class User;
class Resource;
class Environment;

class Authenticator : public QObject
{
    Q_OBJECT
public:
    explicit Authenticator(Environment *env, QObject *parent = 0);
    virtual ~Authenticator();
    bool validate(const QString &username, const QString &password);
    bool canChangeOwner(const User *user, const Resource *resource);
    bool canChangePermissions(const User *user, const Resource *resource);
    bool hasReadPermission(const User *user, const Resource *resource);
    bool hasWritePermission(const User *user, const Resource *resource);

private:
    class Private;
    Private *d;
};

#endif // AUTHENTICATOR_H
