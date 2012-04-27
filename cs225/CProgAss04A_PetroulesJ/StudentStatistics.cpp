/* 
 * File:   StudentStatistics.cpp
 * Author: Jake Petroules
 * 
 * Created on February 22, 2011, 10:15 AM
 */

#include "StudentStatistics.h"
#include <limits>

StudentStatistics::StudentStatistics()
    : m_studentID(0), m_studentName("")
{
}

StudentStatistics::StudentStatistics(const StudentStatistics& orig)
    : m_studentID(0), m_studentName("")
{
    this->m_studentID = orig.m_studentID;
    this->m_studentName = orig.m_studentName;
    this->m_scores = orig.m_scores;
}

StudentStatistics::~StudentStatistics()
{
}

int StudentStatistics::studentID() const
{
    return this->m_studentID;
}

void StudentStatistics::setStudentID(int studentID)
{
    this->m_studentID = studentID;
}

string StudentStatistics::studentName() const
{
    return this->m_studentName;
}

void StudentStatistics::setStudentName(string studentName)
{
    this->m_studentName = studentName;
}

float StudentStatistics::score(string course)
{
    return this->m_scores[course];
}

void StudentStatistics::setScore(string course, float score)
{
    this->m_scores[course] = score;
}

float StudentStatistics::averageScore(const vector<string> courses)
{
    float sumScores = 0;
    for (int i = 0; i < courses.size(); i++)
    {
        sumScores += this->m_scores[courses[i]];
    }

    return sumScores / courses.size();
}

float StudentStatistics::highestScore(const vector<string> courses)
{
    float highestScore = numeric_limits<float>::min();
    for (int i = 0; i < courses.size(); i++)
    {
        if (this->m_scores[courses[i]] > highestScore)
        {
            highestScore = this->m_scores[courses[i]];
        }
    }

    if (highestScore > numeric_limits<float>::min())
    {
        return highestScore;
    }

    return 0;
}

float StudentStatistics::lowestScore(const vector<string> courses)
{
    float lowestScore = numeric_limits<float>::max();
    for (int i = 0; i < courses.size(); i++)
    {
        if (this->m_scores[courses[i]] < lowestScore)
        {
            lowestScore = this->m_scores[courses[i]];
        }
    }

    if (lowestScore < numeric_limits<float>::max())
    {
        return lowestScore;
    }

    return 0;
}
