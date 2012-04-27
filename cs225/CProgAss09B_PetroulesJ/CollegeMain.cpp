/* 
 * File:   CollegeMain.cpp
 * Author: jakepetroules
 *
 * Created on April 22, 2011, 5:02 PM
 */

#include <cstdlib>
#include <iostream>
#include <sstream>
#include <string>
#include <vector>
#include "CollegeMember.h"
#include "Employee.h"
#include "Student.h"
#include "Helpers.h"
#include "EmpAcademicRecord.h"
#include "EmpEmploymentHistory.h"
#include "EmpExtraCurricular.h"
#include "EmpPersonalInfo.h"
#include "EmpPublicationLog.h"

using namespace std;

void getCollegeMemberInfo(CollegeMember *collegeMember);
void addCollegeMember(vector<CollegeMember*> &collegeMembers);
void addEmployee(vector<Employee*> &employees);
void addStudent(vector<Student*> &students);
void findCollegeMember(vector<CollegeMember*> &collegeMembers);
void findEmployee(vector<Employee*> &employees);
void findStudent(vector<Student*> &students);
void listCollegeMembers(vector<CollegeMember*> &collegeMembers, bool sorted);
void listEmployees(vector<Employee*> &employees, bool sorted);
void listStudents(vector<Student*> &students, bool sorted);

int main(int argc, char** argv)
{
    // Create lists to store the three types of people
    vector<CollegeMember*> collegeMembers;
    vector<Employee*> employees;
    vector<Student*> students;
    string input;
    
    do
    {
        // Present a menu to the user
        cout << "Select an option:" << endl;
        cout << "addc - Add a college member" << endl;
        cout << "adde - Add an employee" << endl;
        cout << "adds - Add a student" << endl;
        cout << "findc - Find a college member" << endl;
        cout << "finde - Find an employee" << endl;
        cout << "finds - Find a student" << endl;
        cout << "listc - List the college members" << endl;
        cout << "liste - List the employees" << endl;
        cout << "lists - List the students" << endl;
        cout << "listcs - List the college members (sorted)" << endl;
        cout << "listes - List the employees (sorted)" << endl;
        cout << "listss - List the students (sorted)" << endl;
        cout << "exit - Exit the program" << endl;
        
        // Prompt them to choose a command
        cin >> input;
        
        // Select the correct method to execute based on the command entered
        // by the user
        if (input == "addc")
        {
            addCollegeMember(collegeMembers);
        }
        else if (input == "adde")
        {
            addEmployee(employees);
        }
        else if (input == "adds")
        {
            addStudent(students);
        }
        else if (input == "findc")
        {
            findCollegeMember(collegeMembers);
        }
        else if (input == "finde")
        {
            findEmployee(employees);
        }
        else if (input == "finds")
        {
            findStudent(students);
        }
        else if (input == "listc" || input == "listcs")
        {
            listCollegeMembers(collegeMembers, input == "listcs");
        }
        else if (input == "liste" || input == "listes")
        {
            listEmployees(employees, input == "listes");
        }
        else if (input == "lists" || input == "listss")
        {
            listStudents(students, input == "listss");
        }
    }
    while (input != "exit");
    
    return 0;
}

// Gets the information for a college member from the user, and sets
// the information onto the given instance
void getCollegeMemberInfo(CollegeMember *collegeMember)
{
    if (!collegeMember)
    {
        return;
    }
    
    // Get the ID number from the user
    collegeMember->setId(getInteger("Enter the ID number: ", 0));
    
    // Get the first name from the user...
    string firstName;
    do
    {
        cout << "Enter the first name: ";
        cin >> firstName;
        
        if (firstName.length() == 0 || firstName[0] < 'A' || firstName[0] > 'Z')
        {
            cout << "First name must start with an uppercase letter." << endl;
        }
    }
    while (firstName.length() == 0 || firstName[0] < 'A' || firstName[0] > 'Z');
    
    collegeMember->setFirstName(firstName);
    
    // Get the last name from the user...
    string lastName;
    do
    {
        cout << "Enter the last name: ";
        cin >> lastName;
        
        if (lastName.length() == 0 || lastName[0] < 'A' || lastName[0] > 'Z')
        {
            cout << "Last name must start with an uppercase letter." << endl;
        }
    }
    while (lastName.length() == 0 || lastName[0] < 'A' || lastName[0] > 'Z');
    
    collegeMember->setLastName(lastName);
    
    // Get the address, state, ZIP, telephone, and email from the user
    collegeMember->setAddress1(getNonEmptyString("Enter the address line 1: "));
    collegeMember->setAddress2(getNonEmptyString("Enter the address line 2: "));
    collegeMember->setState(getNonEmptyString("Enter the state: "));
    collegeMember->setZip(getInteger("Enter the ZIP code: ", 0, 999999999));
    collegeMember->setTelephone(getLong("Enter the telephone number (no dashes or spaces): ", 0, 9999999999));
    collegeMember->setEmail(getNonEmptyString("Enter the email: "));
}

void addCollegeMember(vector<CollegeMember*> &collegeMembers)
{
    // Create a new college member
    CollegeMember *collegeMember = new CollegeMember();
    
    // Get their information from the user
    getCollegeMemberInfo(collegeMember);
    
    // Insert the new college member into the list
    collegeMembers.push_back(collegeMember);
}

void addEmployee(vector<Employee*> &employees)
{
    // Create a new employee
    Employee *employee = new Employee();
    
    // Get ALL their information from the user (this is a lot!)
    getCollegeMemberInfo(employee);
    employee->setDepartment(getNonEmptyString("Enter the department: "));
    employee->setJobTitle(getNonEmptyString("Enter the job title: "));
    employee->setSalary(getInteger("Enter the salary: ", 0));
    
    EmpAcademicRecord *ear = employee->academicRecord();
    ear->setReferenceNumber(getInteger("Enter the academic record reference number: ", 0));
    ear->setInstitution(getNonEmptyString("Enter the institution: "));
    ear->setAwardObtained(getNonEmptyString("Enter the award obtained: "));
    ear->setStartDate(getDate("Enter the start date (YYYYMMDD): "));
    ear->setEndDate(getDate("Enter the end date (YYYYMMDD): "));
    
    EmpEmploymentHistory *eeh = employee->employmentHistory();
    eeh->setReferenceNumber(getInteger("Enter the employment history reference number: ", 0));
    eeh->setOrganization(getNonEmptyString("Enter the organization: "));
    eeh->setPositionHeld(getNonEmptyString("Enter the position held: "));
    eeh->setStartDate(getDate("Enter the start date (YYYYMMDD): "));
    eeh->setEndDate(getDate("Enter the end date (YYYYMMDD): "));
    
    EmpExtraCurricular *eec = employee->extraCurricular();
    eec->setReferenceNumber(getInteger("Enter the extra curricular reference number: ", 0));
    eec->setFavoriteSport(getNonEmptyString("Enter the favorite sport: "));
    eec->setOtherSports(getNonEmptyString("Enter the other sports: "));
    eec->setOtherInterests(getNonEmptyString("Enter the other interests: "));
    
    EmpPersonalInfo *epi = employee->personalInfo();
    epi->setReferenceNumber(getInteger("Enter the personal info reference number: ", 0));
    epi->setEthnicity(getNonEmptyString("Enter the ethnicity: "));
    epi->setGender(getGender("Enter the gender (m/f): "));
    epi->setCountryOfOrigin(getNonEmptyString("Enter the country of origin: "));
    epi->setNumberOfDependents(getInteger("Enter the number of dependents: ", 0));
    
    EmpPublicationLog *epl = employee->publicationLog();
    epl->setReferenceNumber(getInteger("Enter the publication log reference number: ", 0));
    epl->setPublicationTitle(getNonEmptyString("Enter the publication title: "));
    epl->setPublicationType(getNonEmptyString("Enter the publication type: "));
    epl->setPublicationDate(getDate("Enter the publication date: "));
    
    // Insert the new employee into the list
    employees.push_back(employee);
}

void addStudent(vector<Student*> &students)
{
    // Create a new student
    Student *student = new Student();
    
    // Get their information from the user
    getCollegeMemberInfo(student);
    student->setAcademicDepartment(getNonEmptyString("Enter the academic department: "));
    student->setMajor(getNonEmptyString("Enter the major: "));
    
    // Insert the new student into the list
    students.push_back(student);
}

void findCollegeMember(vector<CollegeMember*> &collegeMembers)
{
    // Get the ID to search from the user
    int id = getInteger("Enter the ID to find: ", 0);
    
    // Go through each item in the list
    for (int i = 0; i < collegeMembers.size(); i++)
    {
        // If the IDs match, print the information for that college member
        if (collegeMembers[i]->id() == id)
        {
            cout << *collegeMembers[i];
        }
    }
}

void findEmployee(vector<Employee*> &employees)
{
    // Get the ID to search from the user
    int id = getInteger("Enter the ID to find: ", 0);
    
    // Go through each item in the list
    for (int i = 0; i < employees.size(); i++)
    {
        // If the IDs match, print the information for that employee
        if (employees[i]->id() == id)
        {
            cout << *employees[i];
        }
    }
}

void findStudent(vector<Student*> &students)
{
    // Get the ID to search from the user
    int id = getInteger("Enter the ID to find: ", 0);
    
    // Go through each item in the list
    for (int i = 0; i < students.size(); i++)
    {
        // If the IDs match, print the information for that student
        if (students[i]->id() == id)
        {
            cout << *students[i];
        }
    }
}

void listCollegeMembers(vector<CollegeMember*> &collegeMembers, bool sorted)
{
    vector<CollegeMember*> list = collegeMembers;
 
    // If the user wants to display a sorted list...
    if (sorted)
    {
        // Copy the original list to a new list
        vector<CollegeMember*> sortedList = copyVector(collegeMembers);
        
        // Sort it using quicksort
        quicksort(sortedList);
        list = sortedList;
    }
    
    // Print the information for each college member in the list
    for (int i = 0; i < list.size(); i++)
    {
        cout << *list[i];
    }
}

void listEmployees(vector<Employee*> &employees, bool sorted)
{
    vector<Employee*> list = employees;
    
    // If the user wants to display a sorted list...
    if (sorted)
    {
        // Copy the original list to a new list
        vector<Employee*> sortedList = copyVector(employees);
        
        // Sort it using quicksort
        quicksort(sortedList);
        list = sortedList;
    }
    
    // Print the information for each employee in the list
    for (int i = 0; i < list.size(); i++)
    {
        cout << *list[i];
    }
}

void listStudents(vector<Student*> &students, bool sorted)
{
    vector<Student*> list = students;
    
    // If the user wants to display a sorted list...
    if (sorted)
    {
        // Copy the original list to a new list
        vector<Student*> sortedList = copyVector(students);
        
        // Sort it using quicksort
        quicksort(sortedList);
        list = sortedList;
    }
    
    // Print the information for each student in the list
    for (int i = 0; i < list.size(); i++)
    {
        cout << *list[i];
    }
}
