/* 
 * File:   Helpers.h
 * Author: jakepetroules
 *
 * Created on April 22, 2011, 6:35 PM
 */

#ifndef HELPERS_H
#define	HELPERS_H
    
#include <cstdlib>
#include <iostream>
#include <sstream>
#include <string>

using namespace std;

int getInteger(string prompt, int min = numeric_limits<int>::min(), int max = numeric_limits<int>::max());
long long getLong(string prompt, long long min = numeric_limits<long long>::min(), long long max = numeric_limits<long long>::max());

// Checks if the given string is an integer
bool isInteger(string str)
{
    for (int i = 0; i < str.length(); i++)
    {
        // For each character in the string, if it's outside the range 0-9 it cannot be an integer
        if (str[i] < '0' || str[i] > '9')
        {
            return false;
        }
    }
    
    return true;
}

// Convert the given string to an integer
int toInteger(string str)
{
    int i;
    istringstream stream(str);
    stream >> i;   
    return i;
}

// Convert the given string to a 64-bit integer
long long toLong(string str)
{
    long long i;
    istringstream stream(str);
    stream >> i;
    return i;
}

// Get a string from the user - keep prompting them until they enter one that is not empty
string getNonEmptyString(string prompt)
{
    string str;
    do
    {
        cout << prompt;
        getline(cin, str);
    }
    while (str.length() == 0);
    
    return str;
}

// Get an integer from the user - min and max are the minimum and maximum numbers that may be entered
int getInteger(string prompt, int min, int max)
{
    int x = min - 1;
    do
    {
        cout << prompt;
        string str;
        cin >> str;
        if (isInteger(str))
        {
            x = toInteger(str);
        }
    }
    while (x < min || x > max);
    
    return x;
}

// Get a 64-bit integer from the user - min and max are the minimum and maximum numbers that may be entered
long long getLong(string prompt, long long min, long long max)
{
    long long x = min - 1;
    do
    {
        cout << prompt;
        string str;
        cin >> str;
        if (isInteger(str))
        {
            x = toLong(str);
        }
    }
    while (x < min || x > max);
    
    return x;
}

// Copies the specified vector to a new vector
template <typename T> vector<T> copyVector(vector<T> &list)
{
    // Create a new list
    vector<T> newList;
    
    // Add all the items from the old list to the new list
    for (int i = 0; i < list.size(); i++)
    {
        newList.push_back(list[i]);
    }
    
    // Return the new list
    return newList;
}

// This is a helper method for quicksort
template <typename T> int partition(vector<T> &a, int left, int right)
{
    T pivot = a[left];
    while (true)
    {
        while (a[left]->id() < pivot->id()) left++;
        while (a[right]->id() > pivot->id()) right--;
        if (left < right)
        {
            T temp = a[left];
            a[left] = a[right];
            a[right] = temp;
        }
        else
        {
            return right;
        }
    }
}

// Uses the quicksort algorithm to sort the specified vector
template <typename T> void quicksort(vector<T> &a, int left, int right)
{
    if (left < right)
    {
        int pivot = partition(a, left, right);
        quicksort(a, left, pivot - 1);
        quicksort(a, pivot + 1, right);
    }
}

// Uses the quicksort algorithm to sort the specified vector
template <typename T> void quicksort(vector<T> &a)
{
    quicksort(a, 0, a.size() - 1);
}

#endif	/* HELPERS_H */

