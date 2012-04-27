/* 
 * File:   EmpAcademicRecord.h
 * Author: jakepetroules
 *
 * Created on April 23, 2011, 9:15 PM
 */

#ifndef EMPACADEMICRECORD_H
#define	EMPACADEMICRECORD_H

#include "properties.h"
#include <string>

using namespace std;

class EmpAcademicRecord
{
    friend class Employee;
    
public:
    virtual ~EmpAcademicRecord();
    // This might not look like valid C++ but it is - see properties.h
    propertydef(int, r,R,eferenceNumber);
    propertydef(string, i,I,nstitution);
    propertydef(string, a,A,wardObtained);
    propertydef(int, s,S,tartDate);
    propertydef(int, e,E,ndDate);
    string toString() const;
    
private:
    EmpAcademicRecord();
    EmpAcademicRecord(const EmpAcademicRecord &orig);
    int m_referenceNumber;
    string m_institution;
    string m_awardObtained;
    int m_startDate;
    int m_endDate;
};

#endif	/* EMPACADEMICRECORD_H */

