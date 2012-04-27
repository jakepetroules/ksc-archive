/* 
 * File:   CollegeMember.cpp
 * Author: jakepetroules
 * 
 * Created on April 22, 2011, 5:08 PM
 */

#include "CollegeMember.h"

CollegeMember::CollegeMember()
    : m_id(-1), m_firstName(""), m_lastName(""), m_address1(""), m_address2(""),
      m_state(""), m_zip(0), m_telephone(0), m_email("")
{
}

CollegeMember::CollegeMember(const CollegeMember &orig)
{
    this->copy(orig);
}

CollegeMember::~CollegeMember()
{
}

void CollegeMember::copy(const CollegeMember &orig)
{
    this->setId(orig.id());
    this->setFirstName(orig.firstName());
    this->setLastName(orig.lastName());
    this->setAddress1(orig.address1());
    this->setAddress2(orig.address2());
    this->setState(orig.state());
    this->setZip(orig.zip());
    this->setTelephone(orig.telephone());
    this->setEmail(orig.email());
}

int CollegeMember::id() const
{
    return this->m_id;
}

void CollegeMember::setId(int id)
{
    this->m_id = id;
}

string CollegeMember::firstName() const
{
    return this->m_firstName;
}

void CollegeMember::setFirstName(string firstName)
{
    this->m_firstName = firstName;
}

string CollegeMember::lastName() const
{
    return this->m_lastName;
}

void CollegeMember::setLastName(string lastName)
{
    this->m_lastName = lastName;
}

string CollegeMember::address1() const
{
    return this->m_address1;
}

void CollegeMember::setAddress1(string address1)
{
    this->m_address1 = address1;
}

string CollegeMember::address2() const
{
    return this->m_address2;
}

void CollegeMember::setAddress2(string address2)
{
    this->m_address2 = address2;
}

string CollegeMember::state() const
{
    return this->m_state;
}

void CollegeMember::setState(string state)
{
    this->m_state = state;
}

int CollegeMember::zip() const
{
    return this->m_zip;
}

void CollegeMember::setZip(int zip)
{
    this->m_zip = zip;
}

long long CollegeMember::telephone() const
{
    return this->m_telephone;
}

void CollegeMember::setTelephone(long long telephone)
{
    this->m_telephone = telephone;
}

string CollegeMember::email() const
{
    return this->m_email;
}

void CollegeMember::setEmail(string email)
{
    this->m_email = email;
}

string CollegeMember::toString(bool prefixes) const
{
    // The prefixes parameter exists to control whether we add the labels
    // ID, First name, etc, before the data. We will want this to be true
    // when displaying information to the user, and false when writing to file
    stringstream stream;
    stream << (prefixes ? "ID: " : "") << this->m_id << endl;
    stream << (prefixes ? "First name: " : "") << this->m_firstName << endl;
    stream << (prefixes ? "Last name: " : "") << this->m_lastName << endl;
    stream << (prefixes ? "Address line 1: " : "") << this->m_address1 << endl;
    stream << (prefixes ? "Address line 2: " : "") << this->m_address2 << endl;
    stream << (prefixes ? "State: " : "") << this->m_state << endl;
    stream << (prefixes ? "ZIP: " : "") << this->m_zip << endl;
    stream << (prefixes ? "Telephone: " : "") << this->m_telephone << endl;
    stream << (prefixes ? "Email: " : "") << this->m_email << endl;
    return stream.str();
}

ostream &operator<<(ostream &stream, CollegeMember collegeMember)
{
    stream << collegeMember.toString();
    return stream;
}