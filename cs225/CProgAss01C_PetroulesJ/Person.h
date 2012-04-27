/* 
 * File:   Person.h
 * Author: Jake Petroules
 *
 * Created on February 3, 2011, 11:52 AM
 */

#ifndef PERSON_H
#define	PERSON_H

#include <cstdlib>
#include <iostream>

using namespace std;

class Person {
public:
    enum Gender
    {
        Male,
        Female
    };

    Person();
    Person(const Person& orig);
    Person(string first, string middle, string last, Gender gender);
    virtual ~Person();
    string firstName() const;
    string middleName() const;
    string lastName() const;
    string fullName() const;
    string initials() const;
    Gender gender() const;
    void setFirstName(const string &firstName);
    void setMiddleName(const string &middleName);
    void setLastName(const string &lastName);
    void setGender(Gender gender);
    void setGender(const string &gender);
private:
    string m_firstName;
    string m_middleName;
    string m_lastName;
    Gender m_gender;
};

#endif	/* PERSON_H */

