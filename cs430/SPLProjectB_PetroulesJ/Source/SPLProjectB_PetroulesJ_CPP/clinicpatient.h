#ifndef CLINICPATIENT_H
#define CLINICPATIENT_H

#include <QtCore>

class ClinicPatient
{
public:
    ClinicPatient(int id, QString name, int telephoneNumber);
    int id() const;
    void setId(int id);
    QString name() const;
    void setName(const QString &name);
    int telephoneNumber() const;
    void setTelephoneNumber(int telephoneNumber);

private:
    /*!
        The patient's ID number.
     */
    int m_id;

    /*!
        The patient's name.
     */
    QString m_name;

    /*!
        The patient's telephone number.
     */
    int m_telephoneNumber;
};

#endif // CLINICPATIENT_H
