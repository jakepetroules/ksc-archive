#include "passwordchangecommand.h"
#include "user.h"
#include <QTextStream>

PasswordChangeCommand::PasswordChangeCommand(QStringList args, QObject *parent) :
    Command(args, parent)
{
    setName(commandName());
}

bool PasswordChangeCommand::execute(Environment &env)
{
    // Only root can change other users' passwords
    if (!env.user()->isRoot())
    {
        env.insufficientPermissions();
        return false;
    }

    QTextStream in(stdin);

    if (args().size() == 1)
    {
        // Changing other user's password
        QString otherUserName = args().first();
        User *otherUser = env.database().getUser(otherUserName);

        if (!otherUser)
        {
            env.objectDoesNotExist(otherUserName);
            return false;
        }

        env.display(QString("Enter new password for %1: ").arg(otherUserName), false);
        QString newPassword = in.readLine();

        otherUser->setPassword(newPassword);

        env.display("Password successfully changed.");
    }
    else
    {
        // Changing own password...
        env.display("Enter current password: ", false);
        QString current = in.readLine();
        if (current != env.user()->password())
        {
            env.display("Incorrect password.");
            return false;
        }

        env.display("Enter new password: ", false);
        QString newPassword = in.readLine();

        env.user()->setPassword(newPassword);

        env.display("Password successfully changed.");
    }

    return true;
}

QString PasswordChangeCommand::commandName()
{
    return "passwd";
}
