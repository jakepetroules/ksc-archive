#ifndef DOCTORQUEUE_H
#define DOCTORQUEUE_H

#include "clinicpatient.h"

class DoctorQueue : public QQueue<ClinicPatient*>
{
public:
    explicit DoctorQueue(const QString &name);
    QString name() const;
    void setName(const QString &name);
    bool isAvailable() const;
    void setAvailable(bool available);

private:
    QString m_name;
    bool m_isAvailable;
};

#endif // DOCTORQUEUE_H
