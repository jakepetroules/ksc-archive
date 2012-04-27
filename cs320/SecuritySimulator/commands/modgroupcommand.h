#ifndef MODGROUPCOMMAND_H
#define MODGROUPCOMMAND_H

#include "command.h"

class ModGroupCommand : public Command
{
    Q_OBJECT
public:
    explicit ModGroupCommand(QStringList args = QStringList(), QObject *parent = 0);
    virtual bool execute(Environment &env);
    static QString commandName();
};

#endif // MODGROUPCOMMAND_H
