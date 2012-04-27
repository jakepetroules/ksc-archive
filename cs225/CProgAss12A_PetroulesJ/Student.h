/* 
 * File:   Student.h
 * Author: jakepetroules
 *
 * Created on April 22, 2011, 5:40 PM
 */

#ifndef STUDENT_H
#define	STUDENT_H

#include "CollegeMember.h"

class Student : public CollegeMember
{
public:
    Student();
    Student(const Student &orig);
    virtual ~Student();
    string academicDepartment() const;
    void setAcademicDepartment(string academicDepartment);
    string major() const;
    void setMajor(string major);
    virtual string toString(bool prefixes = true) const;
    
    friend ostream &operator<<(ostream &stream, Student student);
    
private:
    string m_academicDepartment;
    string m_major;
};

#endif	/* STUDENT_H */

