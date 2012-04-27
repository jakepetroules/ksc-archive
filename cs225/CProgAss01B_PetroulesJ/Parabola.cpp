/* 
 * File:   Parabola.cpp
 * Author: Jake Petroules
 *
 * Created on February 1, 2011, 9:41 PM
 */

#include <cstdlib>
#include <iostream>
#include <cmath>

using namespace std;

int main(int argc, char** argv)
{
    char again = 'n';
    
    do
    {
        cout << "This program calculates the value of a parabola." << endl;

        cout << "Enter the value of A: ";
        double a;
        cin >> a;

        cout << "Enter the value of B: ";
        double b;
        cin >> b;

        cout << "Enter the value of C: ";
        double c;
        cin >> c;

        cout << "Enter the value of x: ";
        double x;
        cin >> x;

        double y = (a * pow(x, 2)) + (b * x) + c;
        cout << "The value of Y is: " << y << endl;

        // Ask the user if they want to run the program again
        cout << "Run again? (y/n) ";
        cin >> again;
        cout << endl;
    }
    while (again == 'y');

    return 0;
}

