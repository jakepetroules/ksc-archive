/* 
 * File:   TemperatureConverter.cpp
 * Author: Jake Petroules
 *
 * Created on February 10, 2011, 1:29 AM
 */

#include <cstdlib>
#include <iostream>

using namespace std;

double toCelsius(double fahrenheit);
double toFahrenheit(double celsius);

int main(int argc, char** argv)
{
    char again = 'n';

    do
    {
        cout << "This is a temperature calculator. Choose one of the following options:" << endl;
        cout << "(a) Convert from Fahrenheit to Celsius" << endl;
        cout << "(b) Convert from Celsius to Fahrenheit" << endl;
        char choice;
        cin >> choice;

        switch (choice)
        {
            case 'a':
                cout << "Enter a Fahrenheit temperature value: ";
                double fahrenheit;
                cin >> fahrenheit;
                cout << "The Celsius temperature value is " << toCelsius(fahrenheit) << endl;
                break;
            case 'b':
                cout << "Enter a Celsius temperature value: ";
                double celsius;
                cin >> celsius;
                cout << "The Fahrenheit temperature value is " << toFahrenheit(celsius) << endl;
                break;
            default:
                cout << "Invalid choice." << endl;
                break;
        }
        
        // Ask the user if they want to run the program again
        cout << "Run again? (y/n) ";
        cin >> again;
        cout << endl;
    }
    while (again == 'y');

    return 0;
}

double toCelsius(double fahrenheit)
{
    return (fahrenheit - 32) * (5.0 / 9.0);
}

double toFahrenheit(double celsius)
{
    return (celsius * (9.0 / 5.0)) + 32;
}