#include "clinicmonitor.h"
#include "inputhelper.h"
#include <iostream>

ClinicMonitor::ClinicMonitor()
{
    this->m_doctors.append(new DoctorQueue("Who"));
    this->m_doctors.append(new DoctorQueue("Bruce Jones"));
    this->m_doctors.append(new DoctorQueue("Lambert Cox"));
    this->m_doctors.append(new DoctorQueue("Karen Jones"));
    this->m_doctors.append(new DoctorQueue("Elvis Foster"));
    this->m_doctors.append(new DoctorQueue("Santa Claus"));
}

void ClinicMonitor::checkQueueState()
{
    QString doctorName = InputHelper::getString("Enter the name of the doctor to check the queue for: ", "Please enter a name.");

    DoctorQueue *doctor = this->findDoctor(doctorName);
    if (doctor)
    {
        std::cout << "Dr. " << qPrintable(doctor->name()) << " is " << (doctor->isAvailable() ? "" : "not") << " available." << std::endl;
    }
    else
    {
        this->noDoctor(doctorName);
    }
}

void ClinicMonitor::setQueueState()
{
    QString doctorName = InputHelper::getString("Enter the name of the doctor to set the queue for: ", "Please enter a name.");

    DoctorQueue *doctor = this->findDoctor(doctorName);
    if (doctor)
    {
        doctor->setAvailable(InputHelper::getBoolean("Do you want to open or close the queue? ", "open", "close"));
    }
    else
    {
        this->noDoctor(doctorName);
    }
}

void ClinicMonitor::patientCheckIn()
{
    int id = InputHelper::getInteger("Enter the patient's ID number: ", "Please enter a valid ID number.");
    QString name = InputHelper::getString("Enter the patient's name: ", "Please enter a name.");
    int telephoneNumber = InputHelper::getInteger("Enter the patient's telephone number: ", "Please enter a valid telephone number.");
    QString doctorName = InputHelper::getString("Enter the name of the doctor the patient wishes to see: ", "Please enter a name.");

    ClinicPatient *patient = new ClinicPatient(id, name, telephoneNumber);
    DoctorQueue *doctor = this->findDoctor(doctorName);
    if (doctor)
    {
        if (doctor->isAvailable())
        {
            doctor->append(patient);
        }
        else
        {
            std::cout << "Dr." << qPrintable(doctor->name()) << " is not available right now. " <<
                    "The patient must try another doctor or cancel their appointment." << std::endl;
        }
    }
    else
    {
        this->noDoctor(doctorName);
    }
}

void ClinicMonitor::patientCheckOut()
{
    QString patientName = InputHelper::getString("Enter the patient's name: ", "Please enter a name.");
    ClinicPatient *patient = this->findPatient(patientName);
    DoctorQueue *doctor = this->findPatientDoctor(patient);
    if (patient)
    {
        doctor->removeAll(patient);
    }
    else
    {
        this->noPatient(patientName);
    }
}

void ClinicMonitor::listDoctors()
{
    std::cout << "There are " << this->m_doctors.size() << " doctors employed at this clinic." << std::endl;
    foreach (DoctorQueue *doctor, this->m_doctors)
    {
        std::cout << qPrintable(doctor->name()) << std::endl;
    }
}

void ClinicMonitor::listQueueContents()
{
    QString doctorName = InputHelper::getString("Enter the name of the physician to list the queue of: ", "Please enter a name.");
    DoctorQueue *doctor = this->findDoctor(doctorName);
    if (doctor)
    {
        std::cout << "There are " << qPrintable(doctor->size() > 0 ? QString::number(doctor->size()) : QString("no")) << " patients in Dr. " << qPrintable(doctorName) << "'s queue." << std::endl;

        QListIterator<ClinicPatient*> i(*doctor);
        while (i.hasNext())
        {
            ClinicPatient *patient = i.next();
            std::cout << qPrintable(patient->name()) << std::endl;
        }
    }
    else
    {
        this->noDoctor(doctorName);
    }
}

void ClinicMonitor::checkForPatient()
{
    QString doctorName = InputHelper::getString("Enter the name of the physician to check the queue of: ", "Please enter a name.");
    QString patientName = InputHelper::getString("Enter the name of the patient to find in the queue: ", "Please enter a name.");
    ClinicPatient *patient = this->findPatient(patientName);
    DoctorQueue *realDoctor = this->findPatientDoctor(patient);
    DoctorQueue *proposedDoctor = this->findDoctor(doctorName);
    if (proposedDoctor)
    {
        if (patient)
        {
            std::cout << qPrintable(patientName) << " is " << (realDoctor == proposedDoctor ? "" : "not") << " in Dr. " << qPrintable(doctorName) << "'s queue." << std::endl;
        }
        else
        {
            this->noPatient(patientName);
        }
    }
    else
    {
        this->noDoctor(doctorName);
    }
}

void ClinicMonitor::switchPatientPhysician()
{
    QString patientName = InputHelper::getString("Enter the name of the patient to switch the physician of: ", "Please enter a name.");
    ClinicPatient *patient = this->findPatient(patientName);
    DoctorQueue *currentDoctor = this->findPatientDoctor(patient);
    if (patient)
    {
        QString newDoctorName = InputHelper::getString("Enter the name of the physician to switch the patient to: ", "Please enter a name.");
        DoctorQueue *newDoctor = this->findDoctor(newDoctorName);
        if (newDoctor)
        {
            currentDoctor->removeAll(patient);
            newDoctor->append(patient);
        }
        else
        {
            this->noDoctor(newDoctorName);
        }
    }
    else
    {
        this->noPatient(patientName);
    }
}

void ClinicMonitor::reassign()
{
    QString doctorFromName = InputHelper::getString("Enter the name of the doctor to reassign the patients from: ", "Please enter a name.");
    DoctorQueue *doctorFrom = this->findDoctor(doctorFromName);
    if (doctorFrom)
    {
        QString doctorToName = InputHelper::getString("Enter the name of the target doctor: ", "Please enter a name.");
        DoctorQueue *doctorTo = this->findDoctor(doctorToName);
        if (doctorTo)
        {
            if (doctorTo->isAvailable())
            {
                while (!doctorFrom->isEmpty())
                {
                    doctorTo->enqueue(doctorFrom->dequeue());
                }
            }
            else
            {
                std::cout << "Dr." << qPrintable(doctorTo->name()) << " is not available right now." << std::endl;
            }
        }
        else
        {
            this->noDoctor(doctorToName);
        }
    }
    else
    {
        this->noDoctor(doctorFromName);
    }
}

/**
 * Returns the queue for the doctor with the specified name.
 * @param name The name of the doctor whose queue to find.
 */
DoctorQueue* ClinicMonitor::findDoctor(const QString &name) const
{
    foreach (DoctorQueue *doctor, this->m_doctors)
    {
        if (doctor->name() == name)
        {
            return doctor;
        }
    }

    return NULL;
}

/**
 * Finds a patient's doctor.
 * @param patient The patient to find the doctor of.
 */
DoctorQueue* ClinicMonitor::findPatientDoctor(ClinicPatient *patient) const
{
    foreach (DoctorQueue *doctor, this->m_doctors)
    {
        if (doctor->contains(patient))
        {
            return doctor;
        }
    }

    return NULL;
}

/**
 * Finds a patient by their name.
 * @param name The name of the patient to find.
 */
ClinicPatient* ClinicMonitor::findPatient(const QString &name) const
{
    foreach (DoctorQueue *doctor, this->m_doctors)
    {
        QListIterator<ClinicPatient*> i(*doctor);
        while (i.hasNext())
        {
            ClinicPatient *patient = i.next();
            if (patient->name() == name)
            {
                return patient;
            }
        }
    }

    return NULL;
}

void ClinicMonitor::noPatient(const QString &patientName) const
{
    std::cout << "No patient by the name " << qPrintable(patientName) << " has checked in to this clinic." << std::endl;
}

void ClinicMonitor::noDoctor(const QString &doctorName) const
{
    std::cout << "No doctor by the name " << qPrintable(doctorName) << " is employed at this clinic." << std::endl;
}
