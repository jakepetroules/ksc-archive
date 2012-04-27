/* 
 * File:   LoveLine.cpp
 * Author: Jake Petroules
 *
 * Created on February 1, 2011, 9:03 PM
 */

#include <cstdlib>
#include <iostream>

using namespace std;

int main(int argc, char** argv)
{
    char again = 'n';

    do
    {
        // Prompt the user for the four names
        cout << "Enter the names of four individuals:" << endl;

        cout << "Name 1: ";
        string name1;
        cin >> name1;

        cout << "Name 2: ";
        string name2;
        cin >> name2;

        cout << "Name 3: ";
        string name3;
        cin >> name3;

        cout << "Name 4: ";
        string name4;
        cin >> name4;
        cout << endl;

        // Print all the messages
        cout << "I love you " << name1 << "." << endl << endl;
        cout << "Sorry I cannot tell you the same " << name2 << ", but I respect you and we will be friends." << endl << endl;
        cout << "I wish I could have more than one spouse, " << name3 << ", because I would surely consider you. But I am with " << name1 << ". Love you anyway." << endl << endl;
        cout << "Hey " << name4 << ", " << name2 << " and " << name3 << " are both single and unattached. Are you available and are you interested? I like " << name3 << ", but I am committed to " << name1 << "." << endl << endl;
        cout << "Well, I have to go now, I have a dinner date with " << name1 << ". Bye." << endl << endl;

        // Ask the user if they want to run the program again
        cout << "Run again? (y/n) ";
        cin >> again;
        cout << endl;
    }
    while (again == 'y');

    return 0;
}
