#ifndef LISTGROUPSCOMMAND_H
#define LISTGROUPSCOMMAND_H

#include "command.h"

class ListGroupsCommand : public Command
{
    Q_OBJECT
public:
    explicit ListGroupsCommand(QStringList args = QStringList(), QObject *parent = 0);
    virtual bool execute(Environment &env);
    static QString commandName();
};

#endif // LISTGROUPSCOMMAND_H
