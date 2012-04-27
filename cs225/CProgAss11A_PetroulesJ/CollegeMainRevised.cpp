/* 
 * File:   CollegeMainRevised.cpp
 * Author: jakepetroules
 *
 * Created on April 22, 2011, 5:02 PM
 */

#include <cstdlib>
#include <iostream>
#include <fstream>
#include <sstream>
#include <string>
#include <vector>
#include "CollegeMember.h"
#include "Employee.h"
#include "Student.h"
#include "Helpers.h"

using namespace std;

void getCollegeMemberInfo(CollegeMember *collegeMember, ifstream &in);
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
    
    // Open our data file
    ifstream in("data.txt", ios::in);
    if (in.is_open())
    {
        // While we're not at the end of the file, we'll begin reading our
        // stored records from the file
        while (!in.eof())
        {
            string input;
            getline(in, input);
            
            // If we read a <C> that indicates a college member
            if (input == "<C>")
            {
                // So create a new college member
                CollegeMember *collegeMember = new CollegeMember();
                
                // and read their information from the stream
                getCollegeMemberInfo(collegeMember, in);
                
                // Add our restored object to the proper array
                collegeMembers.push_back(collegeMember);
            }
            else if (input == "<E>")
            {
                // If we read an <E> that indicates an employee, so
                // create a new employee
                Employee *employee = new Employee();
                
                // and read their information from the stream
                getCollegeMemberInfo(employee, in);
                
                getline(in, input);
                employee->setDepartment(input);
                
                getline(in, input);
                employee->setJobTitle(input);
                
                getline(in, input);
                employee->setSalary(toInteger(input));
                
                // Add our restored object to the proper array
                employees.push_back(employee);
            }
            else if (input == "<S>")
            {
                // If we read an <S> that indicates a student, so
                // create a new student
                Student *student = new Student();
                
                // and read their information from the stream
                getCollegeMemberInfo(student, in);
                
                getline(in, input);
                student->setAcademicDepartment(input);
                
                getline(in, input);
                student->setMajor(input);
                
                // Add our restored object to the proper array
                students.push_back(student);
            }
        }
    }
    else
    {
        cout << "data.txt does not exist, will create new file..." << endl;
    }
    
    // Close our data file
    in.close();
    
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
    
    // Before we exit the program, we'll open a stream to our data file
    // and save all the new records
    ofstream out("data.txt", ios::out);
    if (out.is_open())
    {
        // For each college member, write a <C> and then their information
        for (int i = 0; i < collegeMembers.size(); i++)
        {
            out << "<C>" << endl;
            out << collegeMembers[i]->toString(false);
        }
        
        // For each employee, write an <E> and then their information
        for (int i = 0; i < employees.size(); i++)
        {
            out << "<E>" << endl;
            out << employees[i]->toString(false);
        }
        
        // For each student, write an <S> and then their information
        for (int i = 0; i < students.size(); i++)
        {
            out << "<S>" << endl;
            out << students[i]->toString(false);
        }
    }
    else
    {
        // We encountered some error saving - data's gone, oh well
        cout << "Failed to save data to data.txt." << endl;
    }
    
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
    
    // Get their information from the user
    getCollegeMemberInfo(employee);
    employee->setDepartment(getNonEmptyString("Enter the department: "));
    employee->setJobTitle(getNonEmptyString("Enter the job title: "));
    employee->setSalary(getInteger("Enter the salary: ", 0));
    
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

// Gets info for a college member from a file input stream
void getCollegeMemberInfo(CollegeMember *collegeMember, ifstream &in)
{
    string input;
    
    // Get the ID
    getline(in, input);
    collegeMember->setId(toInteger(input));

    // first name...
    getline(in, input);
    collegeMember->setFirstName(input);

    // last name...
    getline(in, input);
    collegeMember->setLastName(input);

    // address line 1...
    getline(in, input);
    collegeMember->setAddress1(input);

    // address line 2...
    getline(in, input);
    collegeMember->setAddress2(input);

    // state...
    getline(in, input);
    collegeMember->setState(input);

    // ZIP...
    getline(in, input);
    collegeMember->setZip(toInteger(input));

    // telephone number...
    getline(in, input);
    collegeMember->setTelephone(toInteger(input));

    // and email address
    getline(in, input);
    collegeMember->setEmail(input);
}