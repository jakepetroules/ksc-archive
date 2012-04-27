/* 
 * File:   ClassroomManager.cpp
 * Author: Jake Petroules
 *
 * Created on February 22, 2011, 10:14 AM
 */

#include <iostream>
#include <sstream>
#include <limits>
#include "StudentStatistics.h"
#include "GridFormatter.h"

template<class T> string t_to_string(T i);

using namespace std;

int main(int argc, char** argv)
{
    vector<StudentStatistics> students;
    vector<string> courses;
    
    do
    {
        // Present the user with a menu
        cout << "Enter a choice from the following: " << endl;
        cout << "(1) Add/edit a student" << endl;
        cout << "(2) Add a course" << endl;
        cout << "(3) Remove a student" << endl;
        cout << "(4) Remove a course" << endl;
        cout << "(5) Get student count" << endl;
        cout << "(6) Get course count" << endl;
        cout << "(7) Print matrix" << endl;
        cout << "(0) Quit" << endl;
        int choice;
        cin >> choice;

        switch (choice)
        {
            case 1:
            {
                // Prompt for student info...
                StudentStatistics student;

                cout << "Enter the student's ID: ";
                int id;
                cin >> id;
                student.setStudentID(id);

                cout << "Enter the student's name: ";
                string studentName;
                cin.ignore(100, '\n');
                getline(cin, studentName);
                student.setStudentName(studentName);

                // Get the scores for each course
                for (int i = 0; i < courses.size(); i++)
                {
                    cout << "Enter the score for " << courses[i] << ": ";
                    float score;
                    cin >> score;
                    
                    student.setScore(courses[i], score);
                }

                // See if the student with this ID already exists in the DB
                int removeIndex = -1;
                for (int i = 0; i < students.size(); i++)
                {
                    if (students[i].studentID() == id)
                    {
                        removeIndex = i;
                        break;
                    }
                }

                // If we found a student with the same ID, remove him/her and add the new record,
                // which is effectively an update
                if (removeIndex > -1)
                {
                    students.erase(students.begin() + removeIndex);
                    students.push_back(student);
                    cout << "Student updated!" << endl;
                }
                else
                {
                    students.push_back(student);
                    cout << "Student added! Now " << students.size() << " students in the list." << endl;
                }

                break;
            }
            case 2:
            {
                // Add a course to the list
                cout << "Enter the name of the course to add: ";
                string newCourseName;
                cin.ignore(100, '\n');
                getline(cin, newCourseName);

                courses.push_back(newCourseName);

                break;
            }
            case 3:
            {
                // Remove a student from the list
                cout << "Enter the name of the student to remove: ";
                string removeName;
                cin.ignore(100, '\n');
                getline(cin, removeName);

                int index = -1;
                for (int i = 0; i < students.size(); i++)
                {
                    if (students[i].studentName() == removeName)
                    {
                        index = i;
                        break;
                    }
                }

                // If we found a student to remove, show the proper message
                if (index > -1)
                {
                    students.erase(students.begin() + index);
                    cout << "Student removed! Now " << students.size() << " students in the list." << endl;
                }
                else
                {
                    cout << "Student not found. No changes made." << endl;
                }

                break;
            }
            case 4:
            {
                // Remove a course from the list
                cout << "Enter the name of the course to remove: ";
                string removeName;
                cin.ignore(100, '\n');
                getline(cin, removeName);

                int index = -1;
                for (int i = 0; i < courses.size(); i++)
                {
                    if (courses[i] == removeName)
                    {
                        index = i;
                        break;
                    }
                }

                // If we actually found a course to remove, show the proper message
                if (index > -1)
                {
                    courses.erase(courses.begin() + index);
                    cout << "Course removed! Now " << courses.size() << " courses in the list." << endl;
                }
                else
                {
                    cout << "Course not found. No changes made." << endl;
                }

                break;
            }
            case 5:
                cout << students.size() << " students in the list." << endl;
                break;
            case 6:
                cout << courses.size() << " courses in the list." << endl;
                break;
            case 7:
            {
                // Initialize the grid formatter with the following headers
                vector<string> headers;
                headers.push_back("ID");
                headers.push_back("Name");

                for (int i = 0; i < courses.size(); i++)
                {
                    headers.push_back(courses[i]);
                }

                headers.push_back("AVG");
                headers.push_back("MAX");
                headers.push_back("MIN");
                GridFormatter formatter(headers);

                // Stores the sum of each student's scores for each course
                float scoreSums[courses.size()];
                float scoreMaxes[courses.size()];
                float scoreMins[courses.size()];

                // Initialize score maxes and mins properly
                for (int i = 0; i < courses.size(); i++)
                {
                    scoreMaxes[i] = numeric_limits<float>::min();
                    scoreMins[i] = numeric_limits<float>::max();
                }

                // For every student in the school...
                for (int i = 0; i < students.size(); i++)
                {
                    // Create a row with the student's ID and name
                    vector<string> row;
                    row.push_back(t_to_string(students[i].studentID()));
                    row.push_back(students[i].studentName());

                    // Add all the scores, and add the scores for this student to the sums
                    float scores[courses.size()];
                    for (int j = 0; j < courses.size(); j++)
                    {
                        scores[j] = students[i].score(courses[j]);
                        row.push_back(t_to_string(scores[j]));
                        scoreSums[j] += scores[j];

                        if (scores[j] > scoreMaxes[j])
                        {
                            scoreMaxes[j] = scores[j];
                        }

                        if (scores[j] < scoreMins[j])
                        {
                            scoreMins[j] = scores[j];
                        }
                    }

                    // Add the averages, highs, and lows for this student in all courses
                    row.push_back(t_to_string(students[i].averageScore(courses)));
                    row.push_back(t_to_string(students[i].highestScore(courses)));
                    row.push_back(t_to_string(students[i].lowestScore(courses)));

                    // Add the student row to the grid
                    formatter.addRow(row);
                }

                // Display the grid
                cout << formatter.toString();

                // Now get ready to display the course analysis...
                vector<string> courseHeaders;
                courseHeaders.push_back("Course");
                courseHeaders.push_back("AVG");
                courseHeaders.push_back("MAX");
                courseHeaders.push_back("MIN");
                GridFormatter courseFormatter(courseHeaders);

                for (int i = 0; i < courses.size(); i++)
                {
                    vector<string> row;
                    row.push_back(courses[i]);
                    row.push_back(t_to_string(scoreSums[i] / students.size()));
                    row.push_back(t_to_string(scoreMaxes[i]));
                    row.push_back(t_to_string(scoreMins[i]));
                    courseFormatter.addRow(row);
                }

                cout << courseFormatter.toString();

                break;
            }
            default:
                return 0;
        }
    }
    while (true);

    return 0;
}

// Converts some arbitrary type (such as an integer) to a string
template<class T> string t_to_string(T i)
{
    stringstream ss;
    string s;
    ss << i;
    s = ss.str();

    return s;
}
