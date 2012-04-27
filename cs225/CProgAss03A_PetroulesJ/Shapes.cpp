/* 
 * File:   Shapes.cpp
 * Author: Jake Petroules
 *
 * Created on February 16, 2011, 8:49 PM
 */

#include <cstdlib>
#include <iostream>

using namespace std;

int main(int argc, char** argv)
{
    cout << "(1) Draw line" << endl;
    cout << "(2) Draw rectangle" << endl;
    cout << "(3) Draw square" << endl;
    cout << "(4) Draw isoceles triangle" << endl;

    int selection;
    cin >> selection;

    switch (selection)
    {
        case 1:
            cout << "Enter length of line: ";
            int lineLength;
            cin >> lineLength;

            for (int i = 0; i < lineLength; i++)
            {
                cout << "*";
            }

            cout << endl;

            break;
        case 2:
            cout << "Enter length of rectangle: ";
            int rectangleLength;
            cin >> rectangleLength;

            cout << "Enter width of rectangle: ";
            int rectangleWidth;
            cin >> rectangleWidth;

            for (int i = 0; i < rectangleLength; i++)
            {
                for (int j = 0; j < rectangleWidth; j++)
                {
                    cout << "*";
                }

                cout << endl;
            }

            break;
        case 3:
            cout << "Enter width of square: ";
            int squareWidth;
            cin >> squareWidth;

            for (int i = 0; i < squareWidth; i++)
            {
                for (int j = 0; j < squareWidth; j++)
                {
                    cout << "*";
                }

                cout << endl;
            }

            break;
        case 4:
            cout << "Enter height of triangle: ";
            int triangleHeight;
            cin >> triangleHeight;

            cout << "Enter base of triangle: ";
            int triangleBase;
            cin >> triangleBase;

            for (int i = 0; i < triangleHeight; i++)
            {
                int lineWidth = triangleBase * ((i + 1.0) / triangleHeight);
                int padWidth = (triangleBase - lineWidth) / 2;

                for (int p = 0; p < padWidth; p++)
                {
                    cout << " ";
                }

                for (int j = 0; j < lineWidth; j++)
                {
                    cout << "*";
                }

                cout << endl;
            }

            break;
    }

    return 0;
}
