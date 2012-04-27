#ifndef ADDUSERCOMMAND_H
#define ADDUSERCOMMAND_H

#include "command.h"

class AddUserCommand : public Command
{
    Q_OBJECT
public:
    explicit AddUserCommand(QStringList args = QStringList(), QObject *parent = 0);
    virtual bool execute(Environment &env);
    static QString commandName();
};

#endif // ADDUSERCOMMAND_H
