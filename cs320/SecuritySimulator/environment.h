#ifndef ENVIRONMENT_H
#define ENVIRONMENT_H

#include <QObject>
#include "database.h"
#include "authenticator.h"

class User;

class Environment : public QObject
{
    Q_OBJECT
public:
    explicit Environment(QObject *parent = 0);
    virtual ~Environment();
    bool login(const QString &username, const QString &password);
    User *user() const;
    Database &database() const;
    Authenticator &authenticator() const;
    QString prompt();
    void display(const QString &message, bool newline = true);

    void insufficientPermissions();
    void invalidCommandFormat();
    void objectDoesNotExist(const QString &objectName);

private:
    class Private;
    Private *d;
};

#endif // ENVIRONMENT_H
