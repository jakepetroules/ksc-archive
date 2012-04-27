#include "clinicpatient.h"

/*!
    \class ClinicPatient
    Represents a patient in a medical complex.
 */

/*!
    Initializes a new instance of the {\a ClinicPatient} class.
    \param id The patient's ID number.
    \param name The patient's name.
    \param telephoneNumber The patient's telephone number.
 */
ClinicPatient::ClinicPatient(int id, QString name, int telephoneNumber)
    : m_id(id), m_name(name), m_telephoneNumber(telephoneNumber)
{
}

/*!
    Gets the patient's ID number.
 */
int ClinicPatient::id() const
{
    return this->m_id;
}

/*!
    Sets the patient's ID number.
 */
void ClinicPatient::setId(int id)
{
    this->m_id = id;
}

/*!
    Gets the patient's name.
 */
QString ClinicPatient::name() const
{
    return this->m_name;
}

/*!
    Sets the patient's name.
 */
void ClinicPatient::setName(const QString &name)
{
    this->m_name = name;
}

/*!
    Gets the patient's telephone number.
 */
int ClinicPatient::telephoneNumber() const
{
    return this->m_telephoneNumber;
}

/*!
    Sets the patient's telephone number.
 */
void ClinicPatient::setTelephoneNumber(int telephoneNumber)
{
    this->m_telephoneNumber = telephoneNumber;
}
