/* 
 * File:   EmpPublicationLog.cpp
 * Author: jakepetroules
 * 
 * Created on April 23, 2011, 9:15 PM
 */

#include "EmpPublicationLog.h"
#include <sstream>

EmpPublicationLog::EmpPublicationLog()
    : m_referenceNumber(0), m_publicationTitle(""), m_publicationType(""), m_publicationDate(0)
{
}

EmpPublicationLog::EmpPublicationLog(const EmpPublicationLog &orig)
{
    this->m_referenceNumber = orig.m_referenceNumber;
    this->m_publicationTitle = orig.m_publicationTitle;
    this->m_publicationType = orig.m_publicationType;
    this->m_publicationDate = orig.m_publicationDate;
}

EmpPublicationLog::~EmpPublicationLog()
{
}

// This might not look like valid C++ but it is - see properties.h
propertyimpl(int, EmpPublicationLog, r,R,eferenceNumber);
propertyimpl(string, EmpPublicationLog, p,P,ublicationTitle);
propertyimpl(string, EmpPublicationLog, p,P,ublicationType);
propertyimpl(int, EmpPublicationLog, p,P,ublicationDate);

string EmpPublicationLog::toString() const
{
    stringstream stream;
    stream << "Publication log reference number: " << this->m_referenceNumber << endl;
    stream << "Publication title: " << this->m_publicationTitle << endl;
    stream << "Publication type: " << this->m_publicationType << endl;
    stream << "Publication date: " << this->m_publicationDate << endl;
    return stream.str();
}