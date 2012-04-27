/* 
 * File:   StudentStatistics.h
 * Author: Jake Petroules
 *
 * Created on February 22, 2011, 10:15 AM
 */

#ifndef STUDENTSTATISTICS_H
#define	STUDENTSTATISTICS_H

#include <string>
#include <vector>
#include <map>

using namespace std;

class StudentStatistics
{
public:
    StudentStatistics();
    StudentStatistics(const StudentStatistics& orig);
    virtual ~StudentStatistics();

    int studentID() const;
    void setStudentID(int studentID);
    string studentName() const;
    void setStudentName(string studentName);
    float score(string course);
    void setScore(string course, float score);

    float averageScore(const vector<string> courses);
    float highestScore(const vector<string> courses);
    float lowestScore(const vector<string> courses);

private:
    int m_studentID;
    string m_studentName;
    map<string, float> m_scores;
};

#endif	/* STUDENTSTATISTICS_H */

