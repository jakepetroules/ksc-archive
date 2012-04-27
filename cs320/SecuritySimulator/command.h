#ifndef COMMAND_H
#define COMMAND_H

#include <QObject>
#include <QStringList>
#include "environment.h"

class Command : public QObject
{
    Q_OBJECT
public:
    explicit Command(QStringList args = QStringList(), QObject *parent = 0);
    virtual ~Command();
    QString name() const;
    QStringList args() const;
    static Command* parse(const QString &string);
    virtual bool execute(Environment &env) = 0;

protected:
    void setName(const QString &name);

private:
    class Private;
    Private *d;
};

#endif // COMMAND_H
