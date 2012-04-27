#ifndef USER_H
#define USER_H

#include <QObject>
#include <QDateTime>
#include <QUuid>

class Group;

class User : public QObject
{
    friend class Group;
    friend class Database;

    Q_OBJECT
public:
    explicit User(QObject *parent = 0);
    virtual ~User();
    const QList<Group*> groups() const;
    QUuid code() const;
    void setCode(QUuid code);
    QString userName() const;
    void setUserName(const QString &userName);
    QString password() const;
    void setPassword(const QString &password);
    qint32 passwordChangeCeiling() const;
    void setPasswordChangeCeiling(qint32 passwordChangeCeiling);
    QDateTime lastPasswordChange() const;
    bool isRoot() const;

private:
    void addToGroup(Group *group);
    bool removeFromGroup(Group *group);
    void setLastPasswordChange(const QDateTime &date);

    class Private;
    Private *d;
};

#endif // USER_H
