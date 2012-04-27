/* 
 * File:   MatchFinder.cpp
 * Author: Jake Petroules
 *
 * Created on February 1, 2011, 10:12 PM
 */

#include <cstdlib>
#include <iostream>
#include "Person.h"

using namespace std;

int main(int argc, char** argv)
{
    char again = 'n';

    do
    {
        Person person1;
        Person person2;
        string buffer;

        cout << "Enter the first person's first name: ";
        cin >> buffer;
        person1.setFirstName(buffer);

        cout << "Enter the first person's middle name: ";
        cin >> buffer;
        person1.setMiddleName(buffer);

        cout << "Enter the first person's last name: ";
        cin >> buffer;
        person1.setLastName(buffer);

        cout << "Enter the first person's gender: ";
        cin >> buffer;
        try
        {
            person1.setGender(buffer);
        }
        catch (const string *error)
        {
            cout << "FATAL ERROR: " << *error << endl;
            return 0;
        }

        cout << "Enter the second person's first name: ";
        cin >> buffer;
        person2.setFirstName(buffer);

        cout << "Enter the second person's middle name: ";
        cin >> buffer;
        person2.setMiddleName(buffer);

        cout << "Enter the second person's last name: ";
        cin >> buffer;
        person2.setLastName(buffer);

        cout << "Enter the second person's gender: ";
        cin >> buffer;
        try
        {
            person2.setGender(buffer);
        }
        catch (const string *error)
        {
            cout << "FATAL ERROR: " << *error << endl;
            return 0;
        }

        if (person1.gender() == person2.gender())
        {
            cout << "FATAL ERROR: You must enter one person of each gender." << endl;
        }
        else
        {
            cout << person1.firstName() << ", your initials are " << person1.initials() << endl;
            cout << person2.firstName() << ", your initials are " << person2.initials() << endl;

            Person man = person1.gender() == Person::Male ? person1 : person2;
            Person woman = person1.gender() == Person::Female ? person1 : person2;

            cout << "Congratulations, Mr. and Mrs. " << man.lastName() << "! Welcome to the fraternity of married couples!" << endl;
            cout << woman.firstName() << ", your new name is " << woman.firstName() << " " << woman.middleName() << " " << woman.lastName() << "-" << man.lastName() << ". Congratulations!" << endl;
        }

        // Ask the user if they want to run the program again
        cout << "Run again? (y/n) ";
        cin >> again;
        cout << endl;
    }
    while (again == 'y');

    return 0;
}

