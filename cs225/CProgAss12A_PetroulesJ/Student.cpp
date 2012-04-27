/* 
 * File:   Student.cpp
 * Author: jakepetroules
 * 
 * Created on April 22, 2011, 5:40 PM
 */

#include "Student.h"

Student::Student()
    : CollegeMember(), m_academicDepartment(""), m_major("")
{
}

Student::Student(const Student &orig)
{
    CollegeMember::copy(orig);
    this->setAcademicDepartment(orig.academicDepartment());
    this->setMajor(orig.major());
}

Student::~Student()
{
}

string Student::academicDepartment() const
{
    return this->m_academicDepartment;
}

void Student::setAcademicDepartment(string academicDepartment)
{
    this->m_academicDepartment = academicDepartment;
}

string Student::major() const
{
    return this->m_major;
}

void Student::setMajor(string major)
{
    this->m_major = major;
}

string Student::toString(bool prefixes) const
{
    stringstream stream;
    stream << CollegeMember::toString(prefixes);
    stream << (prefixes ? "Academic department: " : "") << this->m_academicDepartment << endl;
    stream << (prefixes ? "Major: " : "") << this->m_major << endl;
    return stream.str();
}

ostream &operator<<(ostream &stream, Student student)
{
    stream << student.toString();
    return stream;
}