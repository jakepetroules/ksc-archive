#ifndef ADDGROUPCOMMAND_H
#define ADDGROUPCOMMAND_H

#include "command.h"

class AddGroupCommand : public Command
{
    Q_OBJECT
public:
    explicit AddGroupCommand(QStringList args = QStringList(), QObject *parent = 0);
    virtual bool execute(Environment &env);
    static QString commandName();
};

#endif // ADDGROUPCOMMAND_H
