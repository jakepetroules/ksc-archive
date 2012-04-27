#ifndef GROUP_H
#define GROUP_H

#include <QObject>
#include <QUuid>

class User;

class Group : public QObject
{
    Q_OBJECT
public:
    explicit Group(QObject *parent = 0);
    virtual ~Group();
    const QList<User*> users() const;
    void addUser(User *user);
    bool removeUser(User *user);
    QUuid code() const;
    void setCode(QUuid code);
    QString groupName() const;
    void setGroupName(const QString &name);

private:
    class Private;
    Private *d;
};

#endif // GROUP_H
