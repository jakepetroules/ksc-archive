#ifndef REMOVECOMMAND_H
#define REMOVECOMMAND_H

#include "command.h"

class RemoveCommand : public Command
{
    Q_OBJECT
public:
    explicit RemoveCommand(QStringList args = QStringList(), QObject *parent = 0);
    virtual bool execute(Environment &env);
    static QString commandName();
};

#endif // REMOVECOMMAND_H
