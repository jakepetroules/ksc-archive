/* 
 * File:   PayrollMaster.h
 * Author: Jake Petroules
 *
 * Created on February 17, 2011, 11:34 AM
 */

#ifndef PAYROLLMASTER_H
#define	PAYROLLMASTER_H

#define STATE_TAX_MULTIPLIER 0.20
#define EDUCATION_TAX_MULTIPLIER 0.02
#define SOCIAL_SECURITY_MULTIPLIER 0.04
#define MEDICARE_MULTIPLIER 0.04
#define ALL_MULTIPLIERS (STATE_TAX_MULTIPLIER + EDUCATION_TAX_MULTIPLIER + SOCIAL_SECURITY_MULTIPLIER + MEDICARE_MULTIPLIER)

// The number of hours in a regular work week - anything over this is considered overtime
#define WORK_WEEK 40
#define REGULAR_PAY 40
#define OVERTIME_PAY 60

enum DEDUCTIONS
{
    STATE_TAX = 1,
    EDUCATION_TAX = 2,
    SOCIAL_SECURITY = 4,
    MEDICARE = 8,
    ALL_DEDUCTIONS = STATE_TAX | EDUCATION_TAX | SOCIAL_SECURITY | MEDICARE
};

double grossSalary(int hours);
double finalPay(double grossSalary, DEDUCTIONS deductions = ALL_DEDUCTIONS);
void printReport(std::string employeeName, int hoursWorked);

#endif	/* PAYROLLMASTER_H */

