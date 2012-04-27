#include <cstdlib>
#include <limits>
#include <iostream>
#include <sstream>
#include <string>

using namespace std;

class IllegalArgumentException : exception
{
public:
    IllegalArgumentException(const string &what);
    ~IllegalArgumentException() throw();
    const char* what() const throw();

private:
    string m_what;
};

IllegalArgumentException::IllegalArgumentException(const string& what)
{
    this->m_what = what;
}

IllegalArgumentException::~IllegalArgumentException() throw()
{
}

const char* IllegalArgumentException::what() const throw()
{
    return this->m_what.c_str();
}

string enterDate();
bool isLeapYear(int year);
int daysInMonth(int month, bool leapYear);

int main(int argc, char** argv)
{
    cout << "Enter a date:" << endl;
    try
    {
        cout << "The date you entered was: " << enterDate() << endl;
    }
    catch (IllegalArgumentException *e)
    {
        cout << e->what();
    }

    return 0;
}

string enterDate()
{
    const int min = numeric_limits<int>::min();

    cout << "Enter the year: ";
    int year = min;
    do
    {
        cin >> year;
    }
    while (year == min);

    cout << "Enter the month: ";
    int month = 0;
    do
    {
        cin >> month;
    }
    while (month < 1 || month > 12);

    cout << "Enter the day: ";
    int day = 0;
    do
    {
        cin >> day;
    }
    while (day < 1 || day > daysInMonth(month, isLeapYear(year)));

    if (year == 1582 && month == 10 && (day > 4 || day < 15))
    {
        throw new IllegalArgumentException("Dates between October 4th, 1582, and October 15th, 1582, are not valid in the Gregorian calendar. October 4th is followed immediately October 15th\n");
    }
    else if (year == 0)
    {
        throw new IllegalArgumentException("There is no year 0 in the Gregorian calendar - 1 BC is immediately followed by 1 AD\n");
    }

    stringstream dateString;
    dateString << year << "-" << month << "-" << day;
    return dateString.str();
}

bool isLeapYear(int year)
{
    return ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
}

int daysInMonth(int month, bool leapYear)
{
    switch (month)
    {
        // 30 days hath September, April, June, and November.
        case 9:
        case 4:
        case 6:
        case 11:
                return 30;

        // All the rest have 31,
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
                return 31;

        // except February which has 28, and 29 on leap years
        case 2:
                return 28 + (leapYear ? 1 : 0);

        default:
                throw new IllegalArgumentException("month must be between 1 and 12.");
    }
}
