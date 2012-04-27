/* 
 * File:   EmpExtraCurricular.cpp
 * Author: jakepetroules
 * 
 * Created on April 23, 2011, 9:15 PM
 */

#include "EmpExtraCurricular.h"
#include <sstream>

EmpExtraCurricular::EmpExtraCurricular()
    : m_referenceNumber(0), m_favoriteSport(""), m_otherSports(""), m_otherInterests("")
{
}

EmpExtraCurricular::EmpExtraCurricular(const EmpExtraCurricular &orig)
{
    this->m_referenceNumber = orig.m_referenceNumber;
    this->m_favoriteSport = orig.m_favoriteSport;
    this->m_otherSports = orig.m_otherSports;
    this->m_otherInterests = orig.m_otherInterests;
}

EmpExtraCurricular::~EmpExtraCurricular()
{
}

// This might not look like valid C++ but it is - see properties.h
propertyimpl(int, EmpExtraCurricular, r,R,eferenceNumber);
propertyimpl(string, EmpExtraCurricular, f,F,avoriteSport);
propertyimpl(string, EmpExtraCurricular, o,O,therSports);
propertyimpl(string, EmpExtraCurricular, o,O,therInterests);

string EmpExtraCurricular::toString() const
{
    stringstream stream;
    stream << "Extra curricular reference number: " << this->m_referenceNumber << endl;
    stream << "Favorite sport: " << this->m_favoriteSport << endl;
    stream << "Other sports: " << this->m_otherSports << endl;
    stream << "Other interests: " << this->m_otherInterests << endl;
    return stream.str();
}