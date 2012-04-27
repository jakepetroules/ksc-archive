/* 
 * File:   CollegeMember.h
 * Author: jakepetroules
 *
 * Created on April 22, 2011, 5:08 PM
 */

#ifndef COLLEGEMEMBER_H
#define	COLLEGEMEMBER_H

#include <string>
#include <sstream>
#include <iostream>

using namespace std;

class CollegeMember
{
public:
    CollegeMember();
    CollegeMember(const CollegeMember &orig);
    virtual ~CollegeMember();
    int id() const;
    void setId(int id);
    string firstName() const;
    void setFirstName(string firstName);
    string lastName() const;
    void setLastName(string lastName);
    string address1() const;
    void setAddress1(string address1);
    string address2() const;
    void setAddress2(string address2);
    string state() const;
    void setState(string state);
    int zip() const;
    void setZip(int zip);
    long long telephone() const;
    void setTelephone(long long telephone);
    string email() const;
    void setEmail(string email);
    virtual string toString(bool prefixes = true) const;
    
    friend ostream &operator<<(ostream &stream, CollegeMember collegeMember);
    
protected:
    void copy(const CollegeMember &orig);
    
private:
    int m_id;
    string m_firstName;
    string m_lastName;
    string m_address1;
    string m_address2;
    string m_state;
    int m_zip;
    long long m_telephone;
    string m_email;
};

#endif	/* COLLEGEMEMBER_H */

