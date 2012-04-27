/* 
 * File:   EmpExtraCurricular.h
 * Author: jakepetroules
 *
 * Created on April 23, 2011, 9:15 PM
 */

#ifndef EMPEXTRACURRICULAR_H
#define	EMPEXTRACURRICULAR_H

#include "properties.h"
#include <string>

using namespace std;

class EmpExtraCurricular
{
    friend class Employee;
    
public:
    virtual ~EmpExtraCurricular();
    // This might not look like valid C++ but it is - see properties.h
    propertydef(int, r,R,eferenceNumber);
    propertydef(string, f,F,avoriteSport);
    propertydef(string, o,O,therSports);
    propertydef(string, o,O,therInterests);
    string toString() const;
    
private:
    EmpExtraCurricular();
    EmpExtraCurricular(const EmpExtraCurricular &orig);
    int m_referenceNumber;
    string m_favoriteSport;
    string m_otherSports;
    string m_otherInterests;
};

#endif	/* EMPEXTRACURRICULAR_H */

