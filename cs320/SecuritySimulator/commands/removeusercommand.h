#ifndef REMOVEUSERCOMMAND_H
#define REMOVEUSERCOMMAND_H

#include "command.h"

class RemoveUserCommand : public Command
{
    Q_OBJECT
public:
    explicit RemoveUserCommand(QStringList args = QStringList(), QObject *parent = 0);
    virtual bool execute(Environment &env);
    static QString commandName();
};

#endif // REMOVEUSERCOMMAND_H
