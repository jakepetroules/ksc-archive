#include "doctorqueue.h"

DoctorQueue::DoctorQueue(const QString &name)
    : QQueue(), m_name(name)
{
}

QString DoctorQueue::name() const
{
    return this->m_name;
}

void DoctorQueue::setName(const QString &name)
{
    this->m_name = name;
}

bool DoctorQueue::isAvailable() const
{
    return this->m_isAvailable;
}

void DoctorQueue::setAvailable(bool available)
{
    this->m_isAvailable = available;
}
