#include <QtCore/QCoreApplication>
#include "clinicmonitor.h"
#include <iostream>

using namespace std;

int main(int argc, char *argv[])
{
    Q_UNUSED(argc)
    Q_UNUSED(argv)

    ClinicMonitor clinic;

    cout << "> Welcome to Clinic Monitor" << endl;
    cout << "> Available commands:" << endl;
    cout << "> check-queue - Check the status of the queue for a specified doctor" << endl;
    cout << "> set-queue - Open or close the queue for a specified doctor" << endl;
    cout << "> check-in - Check in a patient to the clinic" << endl;
    cout << "> check-out - Check a patient out of the clinic" << endl;
    cout << "> list-doctors - Lists the doctors employed at this clinic" << endl;
    cout << "> list-queue - List the queue for a specified doctor" << endl;
    cout << "> check-for-patient - Checks for the presence of a patient in a particular doctor's queue" << endl;
    cout << "> switch-phys - Switch a patient to a different physician" << endl;
    cout << "> reassign - Move all patients from one doctor to another" << endl;
    cout << "> exit - Exit the application" << endl;

    QTextStream in(stdin, QIODevice::ReadOnly);
    QString option;
    do
    {
        cout << "> Enter a command to run: " << endl;

        in >> option;
        if (option == "check-queue")
        {
            clinic.checkQueueState();
        }
        else if (option == "set-queue")
        {
            clinic.setQueueState();
        }
        else if (option == "check-in")
        {
            clinic.patientCheckIn();
        }
        else if (option == "check-out")
        {
            clinic.patientCheckOut();
        }
        else if (option == "list-doctors")
        {
            clinic.listDoctors();
        }
        else if (option == "list-queue")
        {
            clinic.listQueueContents();
        }
        else if (option == "check-for-patient")
        {
            clinic.checkForPatient();
        }
        else if (option == "switch-phys")
        {
            clinic.switchPatientPhysician();
        }
        else if (option == "reassign")
        {
            clinic.reassign();
        }
    }
    while (!option.isEmpty() && option != "exit");

    // Remove all the patients from all the doctors upon exit
    foreach (DoctorQueue *doctor, clinic.m_doctors)
    {
        while (!doctor->isEmpty())
        {
            doctor->dequeue();
        }
    }
}
