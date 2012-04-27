/* 
 * File:   EmpPublicationLog.h
 * Author: jakepetroules
 *
 * Created on April 23, 2011, 9:15 PM
 */

#ifndef EMPPUBLICATIONLOG_H
#define	EMPPUBLICATIONLOG_H

#include "properties.h"
#include <string>

using namespace std;

class EmpPublicationLog
{
    friend class Employee;
    
public:
    virtual ~EmpPublicationLog();
    // This might not look like valid C++ but it is - see properties.h
    propertydef(int, r,R,eferenceNumber);
    propertydef(string, p,P,ublicationTitle);
    propertydef(string, p,P,ublicationType);
    propertydef(int, p,P,ublicationDate);
    string toString() const;
    
private:
    EmpPublicationLog();
    EmpPublicationLog(const EmpPublicationLog &orig);
    int m_referenceNumber;
    string m_publicationTitle;
    string m_publicationType;
    int m_publicationDate;
};

#endif	/* EMPPUBLICATIONLOG_H */

