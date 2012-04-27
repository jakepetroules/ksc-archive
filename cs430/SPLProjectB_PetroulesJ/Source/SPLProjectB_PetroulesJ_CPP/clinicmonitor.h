#ifndef CLINICMONITOR_H
#define CLINICMONITOR_H

#include "doctorqueue.h"

class ClinicMonitor
{
public:
    ClinicMonitor();
    void checkQueueState();
    void setQueueState();
    void patientCheckIn();
    void patientCheckOut();
    void listDoctors();
    void listQueueContents();
    void checkForPatient();
    void switchPatientPhysician();
    void reassign();
    DoctorQueue* findDoctor(const QString &name) const;
    DoctorQueue* findPatientDoctor(ClinicPatient *patient) const;
    ClinicPatient* findPatient(const QString &name) const;

private:
    void noPatient(const QString &patientName) const;
    void noDoctor(const QString &doctorName) const;

public:
    QList<DoctorQueue*> m_doctors;
};

#endif // CLINICMONITOR_H
