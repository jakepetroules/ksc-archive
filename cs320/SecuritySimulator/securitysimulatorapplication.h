#ifndef SECURITYSIMULATORAPPLICATION_H
#define SECURITYSIMULATORAPPLICATION_H

#include <QCoreApplication>

class SecuritySimulatorApplication : public QCoreApplication
{
    Q_OBJECT
public:
    explicit SecuritySimulatorApplication(int &argc, char **argv, int = ApplicationFlags);
    virtual ~SecuritySimulatorApplication();

public slots:
    void run();

private:
    void attemptAuthentication();
    void enterCommandLoop();
    bool processCommand(const QString &commandString);

    class Private;
    Private *d;
};

#endif // SECURITYSIMULATORAPPLICATION_H
