#include <cstdlib>
#include "PairOfDice.h"
#include <cstdlib>
#include <iostream>

using namespace std;

int main(int argc, char** argv)
{
    int input = 0;

    do
    {
        // Present the user with a menu and ask for a choice
        cout << "Enter a choice: " << endl;
        cout << "(1) Play dice" << endl;
        cout << "(0) Quit" << endl;
        cin >> input;

        // Depending on their choice...
        switch (input)
        {
            // Play dice!
            case 1:
            {
                // Create a pair of dice and roll it
                PairOfDice pair1;
                int roll = pair1.roll();

                // Display the sum of the pair's values
                cout << "pair1 contains: " << roll << endl;

                // Create two more die, on with the maximum face value, and one with a random value
                Die die3(Die::maxFace);
                Die die4((rand() % Die::maxFace) + 1);

                // Create a new pair of dice and set its face values to the 3rd and 4th die
                PairOfDice pair2;
                pair2.setFaces(die3.face(), die4.face());

                // Roll the second pair and display the sum of its values
                cout << "pair2 contains: " << pair2.roll() << endl;

                break;
            }

            // Quit - bye!
            default:
                return 0;
        }
    }
    while (input > 0);

    return 0;
}

