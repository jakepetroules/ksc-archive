/* 
 * File:   PayrollMaster.cpp
 * Author: Jake Petroules
 *
 * Created on February 17, 2011, 11:13 AM
 */

#include <cstdlib>
#include <iostream>
#include "PayrollMaster.h"

using namespace std;

int main(int argc, char** argv)
{
    cout << "Enter the employee's name: ";
    string name;
    getline(cin, name);

    int weeks = 0;
    do
    {
        cout << "Enter the number of weeks in the month (4 or 5): ";
        cin >> weeks;
    }
    while (weeks < 4 || weeks > 5);

    int totalHours = 0;

    for (int i = 0; i < weeks; i++)
    {
        cout << "Enter the employee's hours worked for week " << i + 1 << ": ";
        int hours;
        cin >> hours;
        totalHours += hours;
    }

    printReport(name, totalHours);

    return 0;
}

double grossSalary(int hours)
{
    return (min(hours, WORK_WEEK) * REGULAR_PAY) + (max(hours - WORK_WEEK, 0) * OVERTIME_PAY);
}

double finalPay(double grossSalary, DEDUCTIONS deductions)
{
    double deductionMultiplier = 0;
    deductionMultiplier += ((deductions & STATE_TAX) == STATE_TAX) ? STATE_TAX_MULTIPLIER : 0;
    deductionMultiplier += ((deductions & EDUCATION_TAX) == EDUCATION_TAX) ? EDUCATION_TAX_MULTIPLIER : 0;
    deductionMultiplier += ((deductions & SOCIAL_SECURITY) == SOCIAL_SECURITY) ? SOCIAL_SECURITY_MULTIPLIER : 0;
    deductionMultiplier += ((deductions & MEDICARE) == MEDICARE) ? MEDICARE_MULTIPLIER : 0;

    return grossSalary - (grossSalary * deductionMultiplier);
}

void printReport(string employeeName, int hoursWorked)
{
    double grossPay = grossSalary(hoursWorked);

    cout << "Payroll information for " << employeeName << endl;
    cout << "Gross pay: $" << grossPay << endl;
    cout << "State tax deduction of " << STATE_TAX_MULTIPLIER * 100 << "% - $" << grossPay - finalPay(grossPay, STATE_TAX) << endl;
    cout << "Education tax deduction of " << EDUCATION_TAX_MULTIPLIER * 100 << "% - $" << grossPay - finalPay(grossPay, EDUCATION_TAX) << endl;
    cout << "Social Security deduction of " << SOCIAL_SECURITY_MULTIPLIER * 100 << "% - $" << grossPay - finalPay(grossPay, SOCIAL_SECURITY) << endl;
    cout << "Medicare deduction of " << MEDICARE_MULTIPLIER * 100 << "% - $" << grossPay - finalPay(grossPay, MEDICARE) << endl;
    cout << "Total deductions of " << ALL_MULTIPLIERS * 100 << "% - $" << grossPay - finalPay(grossPay) << endl;
    cout << "The employee's final pay for the month is: $" << finalPay(grossPay) << endl;
}