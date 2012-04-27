#ifndef CHOWNCOMMAND_H
#define CHOWNCOMMAND_H

#include "command.h"

class ChownCommand : public Command
{
    Q_OBJECT
public:
    explicit ChownCommand(QStringList args = QStringList(), QObject *parent = 0);
    virtual bool execute(Environment &env);
    static QString commandName();
};

#endif // CHOWNCOMMAND_H
