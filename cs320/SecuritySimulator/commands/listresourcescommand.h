#ifndef LISTRESOURCESCOMMAND_H
#define LISTRESOURCESCOMMAND_H

#include "command.h"

class ListResourcesCommand : public Command
{
    Q_OBJECT
public:
    explicit ListResourcesCommand(QStringList args = QStringList(), QObject *parent = 0);
    virtual bool execute(Environment &env);
    static QString commandName();
};

#endif // LISTRESOURCESCOMMAND_H
