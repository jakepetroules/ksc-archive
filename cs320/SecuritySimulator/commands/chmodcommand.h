#ifndef CHMODCOMMAND_H
#define CHMODCOMMAND_H

#include "command.h"

class ChmodCommand : public Command
{
    Q_OBJECT
public:
    explicit ChmodCommand(QStringList args = QStringList(), QObject *parent = 0);
    virtual bool execute(Environment &env);
    static QString commandName();
};

#endif // CHMODCOMMAND_H
