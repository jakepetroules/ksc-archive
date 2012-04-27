#ifndef INPUTHELPER_H
#define INPUTHELPER_H

#include <QtCore>

class InputHelper
{
public:
    InputHelper();
    static int getInteger(const QString &promptMessage, const QString &errorMessage);
    static QString getString(const QString &promptMessage, const QString &errorMessage);
    static bool getBoolean(const QString &promptMessage, const QString &yes, const QString &no);
};

#endif // INPUTHELPER_H
