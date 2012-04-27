#ifndef PASSWORDCHANGECOMMAND_H
#define PASSWORDCHANGECOMMAND_H

#include "command.h"

class PasswordChangeCommand : public Command
{
    Q_OBJECT
public:
    explicit PasswordChangeCommand(QStringList args = QStringList(), QObject *parent = 0);
    virtual bool execute(Environment &env);
    static QString commandName();
};

#endif // PASSWORDCHANGECOMMAND_H
