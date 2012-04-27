/* 
 * File:   EmpEmploymentHistory.cpp
 * Author: jakepetroules
 * 
 * Created on April 23, 2011, 9:14 PM
 */

#include "EmpEmploymentHistory.h"
#include <sstream>

EmpEmploymentHistory::EmpEmploymentHistory()
    : m_referenceNumber(0), m_organization(""), m_positionHeld(""), m_startDate(0), m_endDate(0)
{
}

EmpEmploymentHistory::EmpEmploymentHistory(const EmpEmploymentHistory &orig)
{
    this->m_referenceNumber = orig.m_referenceNumber;
    this->m_organization = orig.m_organization;
    this->m_positionHeld = orig.m_positionHeld;
    this->m_startDate = orig.m_startDate;
    this->m_endDate = orig.m_endDate;
}

EmpEmploymentHistory::~EmpEmploymentHistory()
{
}

// This might not look like valid C++ but it is - see properties.h
propertyimpl(int, EmpEmploymentHistory, r,R,eferenceNumber);
propertyimpl(string, EmpEmploymentHistory, o,O,rganization);
propertyimpl(string, EmpEmploymentHistory, p,P,ositionHeld);
propertyimpl(int, EmpEmploymentHistory, s,S,tartDate);
propertyimpl(int, EmpEmploymentHistory, e,E,ndDate);

string EmpEmploymentHistory::toString() const
{
    stringstream stream;
    stream << "Employment history reference number: " << this->m_referenceNumber << endl;
    stream << "Organization: " << this->m_organization << endl;
    stream << "Position held: " << this->m_positionHeld << endl;
    stream << "Start date: " << this->m_startDate << endl;
    stream << "End date: " << this->m_endDate << endl;
    return stream.str();
}