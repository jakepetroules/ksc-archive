#ifndef COMMANDREGISTER_H
#define COMMANDREGISTER_H

#include <QtCore>

class Command;

class CommandRegister
{
public:
    virtual ~CommandRegister();
    static CommandRegister& instance();
    bool contains(const QString &key);
    Command* value(const QString &key);
    QList<Command*> values();

private:
    CommandRegister();
    class Private;
    Private *d;

    CommandRegister(CommandRegister const&); // don't Implement
    void operator=(CommandRegister const&); // don't implement
};

#endif // COMMANDREGISTER_H
