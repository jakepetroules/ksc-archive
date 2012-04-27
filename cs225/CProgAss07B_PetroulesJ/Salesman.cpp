#include "Salesman.h"
#include <sstream>
#include <iostream>

Salesman::Salesman()
    : m_id(-1), m_firstName(""), m_lastName(""), m_street(""), m_city(""), m_state(""),
      m_zip(0), m_telephoneNumber(0), m_emailAddress("")
{
}

Salesman::Salesman(const Salesman& orig)
{
    this->m_id = orig.m_id;
    this->m_firstName = orig.m_firstName;
    this->m_lastName = orig.m_lastName;
    this->m_street = orig.m_street;
    this->m_city = orig.m_city;
    this->m_state = orig.m_state;
    this->m_zip = orig.m_zip;
    this->m_telephoneNumber = orig.m_telephoneNumber;
    this->m_emailAddress = orig.m_emailAddress;
}

Salesman::~Salesman()
{
}

Salesman* Salesman::input()
{
    cout << "Enter the salesman's ID number: ";
    int id;
    cin >> id;

    cout << "Enter the salesman's first name: ";
    string firstName;
    cin >> firstName;

    cout << "Enter the salesman's last name: ";
    string lastName;
    cin >> lastName;

    cout << "Enter the salesman's street address: ";
    string street;
    cin >> street;

    cout << "Enter the salesman's city: ";
    string city;
    cin >> city;

    cout << "Enter the salesman's state: ";
    string state;
    cin >> state;

    cout << "Enter the salesman's ZIP code: ";
    int zip;
    cin >> zip;

    cout << "Enter the salesman's telephone number: ";
    int telephoneNumber;
    cin >> telephoneNumber;

    cout << "Enter the salesman's email address: ";
    string emailAddress;
    cin >> emailAddress;

    Salesman *salesman = new Salesman();
    salesman->setId(id);
    salesman->setFirstName(firstName);
    salesman->setLastName(lastName);
    salesman->setStreet(street);
    salesman->setCity(city);
    salesman->setState(state);
    salesman->setZip(zip);
    salesman->setTelephoneNumber(telephoneNumber);
    salesman->setEmailAddress(emailAddress);
    return salesman;
}

int Salesman::id() const
{
    return this->m_id;
}

void Salesman::setId(int id)
{
    this->m_id = id;
}

string Salesman::firstName() const
{
    return this->m_firstName;
}

void Salesman::setFirstName(string firstName)
{
    this->m_firstName = firstName;
}

string Salesman::lastName() const
{
    return this->m_lastName;
}

void Salesman::setLastName(string lastName)
{
    this->m_lastName = lastName;
}

string Salesman::street() const
{
    return this->m_street;
}

void Salesman::setStreet(string street)
{
    this->m_street = street;
}

string Salesman::city() const
{
    return this->m_city;
}

void Salesman::setCity(string city)
{
    this->m_city = city;
}

string Salesman::state() const
{
    return this->m_state;
}

void Salesman::setState(string state)
{
    this->m_state = state;
}

int Salesman::zip() const
{
    return this->m_zip;
}

void Salesman::setZip(int zip)
{
    this->m_zip = zip;
}

long long Salesman::telephoneNumber() const
{
    return this->m_telephoneNumber;
}

void Salesman::setTelephoneNumber(long long telephoneNumber)
{
    this->m_telephoneNumber = telephoneNumber;
}

string Salesman::emailAddress() const
{
    return this->m_emailAddress;
}

void Salesman::setEmailAddress(string emailAddress)
{
    this->m_emailAddress = emailAddress;
}

string Salesman::nameAndId() const
{
    stringstream out;
    out << this->m_firstName << " " << this->m_lastName << ", " << this->m_id;
    return out.str();
}

string Salesman::toString() const
{
    stringstream out;
    out << "ID: " << this->m_id << endl;
    out << "First name: " << this->m_firstName << endl;
    out << "Last name: " << this->m_lastName << endl;
    out << "Street: " << this->m_street << endl;
    out << "City: " << this->m_city << endl;
    out << "State: " << this->m_state << endl;
    out << "ZIP: " << this->m_zip << endl;
    out << "Telephone number: " << this->m_telephoneNumber << endl;
    out << "Email address: " << this->m_emailAddress << endl;
    return out.str();
}
