/* 
 * File:   Employee.cpp
 * Author: jakepetroules
 * 
 * Created on April 22, 2011, 5:26 PM
 */

#include "Employee.h"

Employee::Employee()
    : CollegeMember(), m_department(""), m_jobTitle(""), m_salary(0)
{
}

Employee::Employee(const Employee &orig)
{
    CollegeMember::copy(orig);
    this->setDepartment(orig.department());
    this->setJobTitle(orig.jobTitle());
    this->setSalary(orig.salary());
}

Employee::~Employee()
{
}

string Employee::department() const
{
    return this->m_department;
}

void Employee::setDepartment(string department)
{
    this->m_department = department;
}

string Employee::jobTitle() const
{
    return this->m_jobTitle;
}

void Employee::setJobTitle(string jobTitle)
{
    this->m_jobTitle = jobTitle;
}

int Employee::salary() const
{
    return this->m_salary;
}

void Employee::setSalary(int salary)
{
    this->m_salary = salary;
}

string Employee::toString() const
{
    stringstream stream;
    stream << CollegeMember::toString();
    stream << "Department: " << this->m_department << endl;
    stream << "Job title: " << this->m_jobTitle << endl;
    stream << "Salary: $" << this->m_salary << endl;
    return stream.str();
}

ostream &operator<<(ostream &stream, Employee employee)
{
    stream << employee.toString();
    return stream;
}