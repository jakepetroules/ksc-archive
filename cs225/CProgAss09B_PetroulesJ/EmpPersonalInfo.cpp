/* 
 * File:   EmpPersonalInfo.cpp
 * Author: jakepetroules
 * 
 * Created on April 23, 2011, 9:14 PM
 */

#include "EmpPersonalInfo.h"
#include <sstream>

EmpPersonalInfo::EmpPersonalInfo()
    : m_referenceNumber(0), m_ethnicity(""), m_gender(""), m_countryOfOrigin(""), m_numberOfDependents(0)
{
}

EmpPersonalInfo::EmpPersonalInfo(const EmpPersonalInfo &orig)
{
    this->m_referenceNumber = orig.m_referenceNumber;
    this->m_ethnicity = orig.m_ethnicity;
    this->m_gender = orig.m_gender;
    this->m_countryOfOrigin = orig.m_countryOfOrigin;
    this->m_numberOfDependents = orig.m_numberOfDependents;
}

EmpPersonalInfo::~EmpPersonalInfo()
{
}

// This might not look like valid C++ but it is - see properties.h
propertyimpl(int, EmpPersonalInfo, r,R,eferenceNumber);
propertyimpl(string, EmpPersonalInfo, e,E,thnicity);
propertyimpl(string, EmpPersonalInfo, g,G,ender);
propertyimpl(string, EmpPersonalInfo, c,C,ountryOfOrigin);
propertyimpl(int, EmpPersonalInfo, n,N,umberOfDependents);

string EmpPersonalInfo::toString() const
{
    stringstream stream;
    stream << "Personal info reference number: " << this->m_referenceNumber << endl;
    stream << "Ethnicity: " << this->m_ethnicity << endl;
    stream << "Gender: " << this->m_gender << endl;
    stream << "Country of origin: " << this->m_countryOfOrigin << endl;
    stream << "Number of dependents: " << this->m_numberOfDependents << endl;
    return stream.str();
}