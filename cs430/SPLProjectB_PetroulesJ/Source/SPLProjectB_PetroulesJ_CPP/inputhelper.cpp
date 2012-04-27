#include "inputhelper.h"
#include <iostream>

InputHelper::InputHelper()
{
}

int InputHelper::getInteger(const QString &promptMessage, const QString &errorMessage)
{
    QTextStream in(stdin, QIODevice::ReadOnly);

    bool ok = false;
    int id = 0;
    do
    {
        std::cout << qPrintable(promptMessage);

        QString line;
        in >> line;

        id = line.toInt(&ok);

        if (!ok)
        {
            std::cout << qPrintable(errorMessage) << std::endl;
        }
    }
    while (!ok);

    return id;
}

QString InputHelper::getString(const QString &promptMessage, const QString &errorMessage)
{
    QTextStream in(stdin, QIODevice::ReadOnly);

    QString name;
    do
    {
        std::cout << qPrintable(promptMessage);

        name = in.readLine();
        if (name.isEmpty() && !errorMessage.isEmpty())
        {
            std::cout << qPrintable(errorMessage) << std::endl;
        }
    }
    while (name.isEmpty());

    return name;
}

bool InputHelper::getBoolean(const QString &promptMessage, const QString &yes, const QString &no)
{
    QTextStream in(stdin, QIODevice::ReadOnly);

    QString openClose;
    do
    {
        std::cout << qPrintable(promptMessage);

        std::cout << "(enter " << qPrintable(yes) << " or " << qPrintable(no) << ") " << std::endl;
        in >> openClose;
    }
    while (openClose != yes && openClose != no);

    return openClose == yes;
}
