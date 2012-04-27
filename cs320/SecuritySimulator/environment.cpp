#include "environment.h"
#include "user.h"
#include <QTextStream>
#include <QDebug>

class Environment::Private
{
public:
    User *user;
    Database database;
    Authenticator *authenticator;
};

Environment::Environment(QObject *parent) :
    QObject(parent)
{
    d = new Private();
    d->user = 0;
    d->authenticator = new Authenticator(this);
}

Environment::~Environment()
{
    delete d->authenticator;
    delete d;
}

bool Environment::login(const QString &username, const QString &password)
{
    if (d->authenticator->validate(username, password))
    {
        d->user = database().getUser(username);
        return true;
    }

    return false;
}

User *Environment::user() const
{
    return d->user;
}

Database &Environment::database() const
{
    return d->database;
}

Authenticator &Environment::authenticator() const
{
    return *d->authenticator;
}

QString Environment::prompt()
{
    if (!d->user)
    {
        qWarning() << "No user is logged in; should not be prompting.";
        return QString();
    }

    display(QString("SecuritySimulator:%1> ").arg(d->user->userName()), false);

    QTextStream in(stdin);
    return in.readLine();
}

void Environment::display(const QString &message, bool newline)
{
    QTextStream out(stdout);
    out << message;
    if (newline)
    {
        out << "\n";
    }
}

void Environment::insufficientPermissions()
{
    display("User does not have permission to perform that operation.");
}

void Environment::invalidCommandFormat()
{
    display("The command was improperly formatted.");
}

void Environment::objectDoesNotExist(const QString &objectName)
{
    display(QString("The object %1 does not exist.").arg(objectName));
}
