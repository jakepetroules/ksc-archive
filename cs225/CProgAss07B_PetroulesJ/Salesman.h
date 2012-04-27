#ifndef SALESMAN_H
#define	SALESMAN_H

#include <string>

using namespace std;

class Salesman
{
public:
    Salesman();
    Salesman(const Salesman& orig);
    virtual ~Salesman();
    static Salesman* input();
    int id() const;
    void setId(int id);
    string firstName() const;
    void setFirstName(string firstName);
    string lastName() const;
    void setLastName(string lastName);
    string street() const;
    void setStreet(string street);
    string city() const;
    void setCity(string city);
    string state() const;
    void setState(string state);
    int zip() const;
    void setZip(int zip);
    long long telephoneNumber() const;
    void setTelephoneNumber(long long telephoneNumber);
    string emailAddress() const;
    void setEmailAddress(string emailAddress);
    string nameAndId() const;
    string toString() const;
    
private:
    int m_id;
    string m_firstName;
    string m_lastName;
    string m_street;
    string m_city;
    string m_state;
    int m_zip;
    long long m_telephoneNumber;
    string m_emailAddress;
};

#endif
