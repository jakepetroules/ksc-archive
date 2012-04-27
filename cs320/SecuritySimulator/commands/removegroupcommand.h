#ifndef REMOVEGROUPCOMMAND_H
#define REMOVEGROUPCOMMAND_H

#include "command.h"

class RemoveGroupCommand : public Command
{
    Q_OBJECT
public:
    explicit RemoveGroupCommand(QStringList args = QStringList(), QObject *parent = 0);
    virtual bool execute(Environment &env);
    static QString commandName();
};

#endif // REMOVEGROUPCOMMAND_H
