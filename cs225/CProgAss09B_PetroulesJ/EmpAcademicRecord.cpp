/* 
 * File:   EmpAcademicRecord.cpp
 * Author: jakepetroules
 * 
 * Created on April 23, 2011, 9:15 PM
 */

#include "EmpAcademicRecord.h"
#include <sstream>

EmpAcademicRecord::EmpAcademicRecord()
    : m_referenceNumber(0), m_institution(""), m_awardObtained(""), m_startDate(0), m_endDate(0)
{
}

EmpAcademicRecord::EmpAcademicRecord(const EmpAcademicRecord &orig)
{
    this->m_referenceNumber = orig.m_referenceNumber;
    this->m_institution = orig.m_institution;
    this->m_awardObtained = orig.m_awardObtained;
    this->m_startDate = orig.m_startDate;
    this->m_endDate = orig.m_endDate;
}

EmpAcademicRecord::~EmpAcademicRecord()
{
}

// This might not look like valid C++ but it is - see properties.h
propertyimpl(int, EmpAcademicRecord, r,R,eferenceNumber);
propertyimpl(string, EmpAcademicRecord, i,I,nstitution);
propertyimpl(string, EmpAcademicRecord, a,A,wardObtained);
propertyimpl(int, EmpAcademicRecord, s,S,tartDate);
propertyimpl(int, EmpAcademicRecord, e,E,ndDate);

string EmpAcademicRecord::toString() const
{
    stringstream stream;
    stream << "Academic record reference number: " << this->m_referenceNumber << endl;
    stream << "Institution: " << this->m_institution << endl;
    stream << "Award obtained: " << this->m_awardObtained << endl;
    stream << "Start date: " << this->m_startDate << endl;
    stream << "End date: " << this->m_endDate << endl;
    return stream.str();
}