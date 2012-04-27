// *****************************************************************************
// Program: StudentList
// Author:  E. Foster, Jake Petroules
// Purpose: Manipulates a list of student records using pointers manipulated via an array
//          This essentially implements a dynamic list
// ****************************************************************************

#include <cstdlib>
#include <iostream>
#include <cctype>
#include <string>
#include <vector>

using namespace std;

typedef int StudentID;

struct Student
{
    StudentID id;
    string name;
    string sex;
    string major;
};

typedef vector<Student*> StudentList;

void inputStudents(StudentList &studentList);
void removeStudent(StudentList &studentList, const StudentID &studentID);
void findAndPrint(const StudentList &studentList, const StudentID &studentID);
void printStudents(const StudentList &studentList);
void printStudentsSorted(const StudentList &studentList);
void printStudent(const Student *student);
void quickSort(StudentList &arr, int left, int right);

int main(int argc, char *argv[])
{
    char exit = 'n';
    StudentList studentList;

    do
    {
        // Show the menu
        cout << "Choose..." << endl;
        cout << "(1) Add students" << endl;
        cout << "(2) Remove student" << endl;
        cout << "(3) Search for student" << endl;
        cout << "(4) Print students" << endl;
        cout << "(5) Print students (sorted)" << endl;

        // Ask the user what option they want to run
        int choice;
        cin >> choice;
        switch (choice)
        {
            case 1:
                // Prompt for student input
                inputStudents(studentList);
                break;
            case 2:
            {
                // Prompt the user for the ID of the student to remove
                cout << "Enter the ID of the student to remove: ";
                StudentID id;
                cin >> id;

                // Then try to remove the student
                removeStudent(studentList, id);
                break;
            }
            case 3:
            {
                // Prompt the user for the ID of the student to find
                cout << "Enter the ID of the student to find: ";
                StudentID id;
                cin >> id;

                // Then try to find the student and print their details
                findAndPrint(studentList, id);
                break;
            }
            case 4:
                // Print the list of students
                printStudents(studentList);
                break;
            case 5:
                // Print the list of students (sorted)
                printStudentsSorted(studentList);
                break;
            default:
                cout << "Invalid choice" << endl;
                break;
        }

        cout << "Press any key to continue or X to exit ";
        cin >> exit;
    }
    while (exit != 'x');

    return 0;
}

void inputStudents(StudentList &studentList)
{
    // Print an introduction message and ask for the number of students to be input
    cout << "Bruce Jones Student List Manager" << endl << endl;
    cout << "How many students? ";
    int numberOfStudents;
    cin >> numberOfStudents;

    // For each student to be input
    for (int i = 0; i < numberOfStudents; i++)
    {
        Student *student = new Student();

        // Prompt for and obtain the details for the student
        cout << "\nEnter details for student " << (i + 1) << endl;

        cout << "\nID Number: ";
        cin >> student->id;
        cin.ignore(100, '\n');

        cout << "\nName: ";
        getline(cin, student->name);

        cout << "\nSex: ";
        getline(cin, student->sex);

        cout << "\nMajor: ";
        getline(cin, student->major);

        // Add the student to the list
        studentList.push_back(student);
    }
}

void removeStudent(StudentList &studentList, const StudentID &studentID)
{
    // Go through all the students...
    int index = -1;
    for (int i = 0; i < studentList.size(); i++)
    {
        // If the IDs match, this is the one to remove
        if (studentList[0]->id == studentID)
        {
            index = i;
            break;
        }
    }

    // If we found a student...
    if (index > -1)
    {
        // Erase 'em!
        studentList.erase(studentList.begin() + index);
        cout << "Student removed" << endl;
    }
    else
    {
        cout << "Student with ID " << studentID << " not found!" << endl;
    }
}

void findAndPrint(const StudentList &studentList, const StudentID &studentID)
{
    // Look through all the students...
    for (int i = 0; i < studentList.size(); i++)
    {
        // If the IDs match...
        if (studentList[0]->id == studentID)
        {
            // Print the details and exit
            printStudent(studentList[0]);
            return;
        }
    }

    // The student was not found
    cout << "Student with ID " << studentID << " not found!" << endl;
}

void printStudents(const StudentList &studentList)
{
    cout << "\nYou have entered information for " << studentList.size() << " student(s) as follows:" << endl;

    // Go through all the students and print info
    for (int i = 0; i < studentList.size(); i++)
    {
        printStudent(studentList[i]);
    }
}

void printStudentsSorted(const StudentList &studentList)
{
    cout << "\nYou have entered information for " << studentList.size() << " student(s) as follows:" << endl;

    // Copy the student list to a new list and sort it using quicksort
    StudentList studentListSorted = studentList;
    quickSort(studentListSorted, 0, studentListSorted.size() - 1);

    // Go through all the students (sorted) and print info
    for (int i = 0; i < studentListSorted.size(); i++)
    {
        printStudent(studentListSorted[i]);
    }
}

void printStudent(const Student *student)
{
    // If student is not null, print details
    if (student)
    {
        cout << "Student ID and name: " << student->id << " - " << student->name << endl;
        cout << "Student sex: " << student->sex << endl;
        cout << "Student major: " << student->major << endl;
    }
}

void quickSort(StudentList &arr, int left, int right)
{
      int i = left, j = right;
      Student *tmp;
      int pivot = arr[(left + right) / 2]->id;

      /* partition */
      while (i <= j)
      {
            while (arr[i]->id < pivot)
                  i++;
            while (arr[j]->id > pivot)
                  j--;
            if (i <= j) {
                  tmp = arr[i];
                  arr[i] = arr[j];
                  arr[j] = tmp;
                  i++;
                  j--;
            }
      };

      /* recursion */
      if (left < j)
            quickSort(arr, left, j);
      if (i < right)
            quickSort(arr, i, right);
}