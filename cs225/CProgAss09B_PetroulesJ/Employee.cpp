/* 
 * File:   Employee.cpp
 * Author: jakepetroules
 * 
 * Created on April 22, 2011, 5:26 PM
 */

#include "Employee.h"
#include "EmpAcademicRecord.h"
#include "EmpEmploymentHistory.h"
#include "EmpExtraCurricular.h"
#include "EmpPersonalInfo.h"
#include "EmpPublicationLog.h"

Employee::Employee()
    : CollegeMember(), m_department(""), m_jobTitle(""), m_salary(0),
        m_academicRecord(new EmpAcademicRecord()), m_employmentHistory(new EmpEmploymentHistory()),
        m_extraCurricular(new EmpExtraCurricular()), m_personalInfo(new EmpPersonalInfo()),
        m_publicationLog(new EmpPublicationLog())
{
}

Employee::Employee(const Employee &orig)
{
    CollegeMember::copy(orig);
    this->setDepartment(orig.department());
    this->setJobTitle(orig.jobTitle());
    this->setSalary(orig.salary());
    this->m_academicRecord = new EmpAcademicRecord(*orig.m_academicRecord);
    this->m_employmentHistory = new EmpEmploymentHistory(*orig.m_employmentHistory);
    this->m_extraCurricular = new EmpExtraCurricular(*orig.m_extraCurricular);
    this->m_personalInfo = new EmpPersonalInfo(*orig.m_personalInfo);
    this->m_publicationLog = new EmpPublicationLog(*orig.m_publicationLog);
}

Employee::~Employee()
{
    delete this->m_academicRecord;
    delete this->m_employmentHistory;
    delete this->m_extraCurricular;
    delete this->m_personalInfo;
    delete this->m_publicationLog;
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

EmpAcademicRecord* Employee::academicRecord()
{
    return this->m_academicRecord;
}

EmpEmploymentHistory* Employee::employmentHistory()
{
    return this->m_employmentHistory;
}

EmpExtraCurricular* Employee::extraCurricular()
{
    return this->m_extraCurricular;
}

EmpPersonalInfo* Employee::personalInfo()
{
    return this->m_personalInfo;
}

EmpPublicationLog* Employee::publicationLog()
{
    return this->m_publicationLog;
}

string Employee::toString() const
{
    stringstream stream;
    stream << CollegeMember::toString();
    stream << "Department: " << this->m_department << endl;
    stream << "Job title: " << this->m_jobTitle << endl;
    stream << "Salary: $" << this->m_salary << endl;
    stream << this->m_academicRecord->toString();
    stream << this->m_employmentHistory->toString();
    stream << this->m_extraCurricular->toString();
    stream << this->m_personalInfo->toString();
    stream << this->m_publicationLog->toString();
    return stream.str();
}

ostream &operator<<(ostream &stream, Employee employee)
{
    stream << employee.toString();
    return stream;
}