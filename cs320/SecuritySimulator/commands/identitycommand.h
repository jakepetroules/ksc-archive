#ifndef IDENTITYCOMMAND_H
#define IDENTITYCOMMAND_H

#include "command.h"

class IdentityCommand : public Command
{
    Q_OBJECT
public:
    explicit IdentityCommand(QStringList args = QStringList(), QObject *parent = 0);
    virtual bool execute(Environment &env);
    static QString commandName();
};

#endif // IDENTITYCOMMAND_H
