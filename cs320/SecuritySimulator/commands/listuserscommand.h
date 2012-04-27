#ifndef LISTUSERSCOMMAND_H
#define LISTUSERSCOMMAND_H

#include "command.h"

class ListUsersCommand : public Command
{
    Q_OBJECT
public:
    explicit ListUsersCommand(QStringList args = QStringList(), QObject *parent = 0);
    virtual bool execute(Environment &env);
    static QString commandName();
};

#endif // LISTUSERSCOMMAND_H
