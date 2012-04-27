/* 
 * File:   RandomBarChart.cpp
 * Author: Jake Petroules
 *
 * Created on February 9, 2011, 8:25 PM
 */

#include <cstdlib>
#include <ctime>
#include <iostream>

#define RANDRANGE(min, max) (rand() % (max - min + 1) + min)

using namespace std;

int main(int argc, char** argv)
{
    srand(time(NULL));

    cout << "Enter the number of bars to display (10-40): ";
    int bars = 0;
    do
    {
        cin >> bars;
    }
    while (bars < 10 || bars > 40);

    cout << "Enter the character to be used for the bar chart: ";
    char character;
    cin >> character;

    for (int i = 0; i < bars; i++)
    {
        int length = RANDRANGE(1, 40);

        for (int i = 0; i < length; i++)
        {
            cout << character;
        }

        cout << endl;
    }

    return 0;
}
