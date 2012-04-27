/* 
 * File:   Employee.h
 * Author: jakepetroules
 *
 * Created on April 22, 2011, 5:26 PM
 */

#ifndef EMPLOYEE_H
#define	EMPLOYEE_H

#include "CollegeMember.h"

class Employee : public CollegeMember
{
public:
    Employee();
    Employee(const Employee &orig);
    virtual ~Employee();
    string department() const;
    void setDepartment(string department);
    string jobTitle() const;
    void setJobTitle(string jobTitle);
    int salary() const;
    void setSalary(int salary);
    virtual string toString() const;
    
    friend ostream &operator<<(ostream &stream, Employee employee);
    
private:
    string m_department;
    string m_jobTitle;
    int m_salary;
};

#endif	/* EMPLOYEE_H */

