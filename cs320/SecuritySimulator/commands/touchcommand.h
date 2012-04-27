#ifndef TOUCHCOMMAND_H
#define TOUCHCOMMAND_H

#include "command.h"

class TouchCommand : public Command
{
    Q_OBJECT
public:
    explicit TouchCommand(QStringList args = QStringList(), QObject *parent = 0);
    virtual bool execute(Environment &env);
    static QString commandName();
};

#endif // TOUCHCOMMAND_H
