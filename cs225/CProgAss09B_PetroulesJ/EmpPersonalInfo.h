/* 
 * File:   EmpPersonalInfo.h
 * Author: jakepetroules
 *
 * Created on April 23, 2011, 9:14 PM
 */

#ifndef EMPPERSONALINFO_H
#define	EMPPERSONALINFO_H

#include "properties.h"
#include <string>

using namespace std;

class EmpPersonalInfo
{
    friend class Employee;
    
public:
    virtual ~EmpPersonalInfo();
    // This might not look like valid C++ but it is - see properties.h
    propertydef(int, r,R,eferenceNumber);
    propertydef(string, e,E,thnicity);
    propertydef(string, g,G,ender);
    propertydef(string, c,C,ountryOfOrigin);
    propertydef(int, n,N,umberOfDependents);
    string toString() const;
    
private:
    EmpPersonalInfo();
    EmpPersonalInfo(const EmpPersonalInfo &orig);
    int m_referenceNumber;
    string m_ethnicity;
    string m_gender;
    string m_countryOfOrigin;
    int m_numberOfDependents;
};

#endif	/* EMPPERSONALINFO_H */

