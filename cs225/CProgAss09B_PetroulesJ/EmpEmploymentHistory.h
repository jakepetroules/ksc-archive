/* 
 * File:   EmpEmploymentHistory.h
 * Author: jakepetroules
 *
 * Created on April 23, 2011, 9:14 PM
 */

#ifndef EMPEMPLOYMENTHISTORY_H
#define	EMPEMPLOYMENTHISTORY_H

#include "properties.h"
#include <string>

using namespace std;

class EmpEmploymentHistory
{
    friend class Employee;
    
public:
    virtual ~EmpEmploymentHistory();
    // This might not look like valid C++ but it is - see properties.h
    propertydef(int, r,R,eferenceNumber);
    propertydef(string, o,O,rganization);
    propertydef(string, p,P,ositionHeld);
    propertydef(int, s,S,tartDate);
    propertydef(int, e,E,ndDate);
    string toString() const;
    
private:
    EmpEmploymentHistory();
    EmpEmploymentHistory(const EmpEmploymentHistory &orig);
    int m_referenceNumber;
    string m_organization;
    string m_positionHeld;
    int m_startDate;
    int m_endDate;
};

#endif	/* EMPEMPLOYMENTHISTORY_H */

