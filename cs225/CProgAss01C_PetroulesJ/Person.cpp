/* 
 * File:   Person.cpp
 * Author: Jake Petroules
 * 
 * Created on February 3, 2011, 11:52 AM
 */

#include "Person.h"

Person::Person()
{
    this->m_firstName = "";
    this->m_middleName = "";
    this->m_lastName = "";
    this->m_gender = Male;
}

Person::Person(const Person& orig)
{
    this->m_firstName = orig.m_firstName;
    this->m_middleName = orig.m_middleName;
    this->m_lastName = orig.m_lastName;
    this->m_gender = orig.m_gender;
}

Person::Person(string first, string middle, string last, Gender gender)
{
    this->m_firstName = first;
    this->m_middleName = middle;
    this->m_lastName = last;
    this->m_gender = gender;
}

Person::~Person()
{
}

string Person::firstName() const
{
    return this->m_firstName;
}

string Person::middleName() const
{
    return this->m_middleName;
}

string Person::lastName() const
{
    return this->m_lastName;
}

string Person::fullName() const
{
    return this->m_firstName + " " + this->m_middleName + " " + this->m_lastName;
}

string Person::initials() const
{
    string initials = "";
    initials += this->m_firstName[0];
    initials += this->m_middleName[0];
    initials += this->m_lastName[0];
    return initials;
}

Person::Gender Person::gender() const
{
    return this->m_gender;
}

void Person::setFirstName(const string& first)
{
    this->m_firstName = first;
}

void Person::setMiddleName(const string& middle)
{
    this->m_middleName = middle;
}

void Person::setLastName(const string& last)
{
    this->m_lastName = last;
}

void Person::setGender(Gender gender)
{
    switch (gender)
    {
        case Male:
        case Female:
            this->m_gender = gender;
            break;
        default:
            throw new string("Invalid gender.");
    }
}

void Person::setGender(const string &gender)
{
    if (gender == "m" || gender == "M" || gender == "male" || gender == "Male")
    {
        this->m_gender = Male;
    }
    else if (gender == "f" || gender == "F" || gender == "female" || gender == "Female")
    {
        this->m_gender = Female;
    }
    else
    {
        throw new string("Invalid gender.");
    }
}