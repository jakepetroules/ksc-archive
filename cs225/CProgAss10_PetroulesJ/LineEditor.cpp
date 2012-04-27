/* 
 * File:   LineEditor.cpp
 * Author: jakepetroules
 *
 * Created on April 22, 2011, 9:27 PM
 */

#include <cstdlib>
#include <iostream>
#include <fstream>

using namespace std;

void createFile();
void modifyFile();
string displayFile();
void deleteFile();

int main(int argc, char** argv)
{
    string option;
    
    do
    {
        // Present the user with a menu
        cout << "Choose one of the following options:" << endl;
        cout << "1 - Create a new file" << endl;
        cout << "2 - Modify an existing file" << endl;
        cout << "3 - Display an existing file" << endl;
        cout << "4 - Delete an existing file" << endl;
        cout << "0 - Exit the application" << endl;
        
        // Get a command from the user
        cin >> option;
        
        // Call the appropriate method depending on the command entered by the user
        if (option == "1")
        {
            createFile();
        }
        else if (option == "2")
        {
            modifyFile();
        }
        else if (option == "3")
        {
            displayFile();
        }
        else if (option == "4")
        {
            deleteFile();
        }
    }
    while (option != "0");
    
    return 0;
}

void createFile()
{
    // Get the name of the file from the user
    cout << "Enter the name of the file: ";
    string fileName;
    cin >> fileName;
    cin.ignore(100, '\n');
    
    string input;
    
    // Create a file stream which creates the specified file
    fstream file(fileName.c_str(), ios::out);
    do
    {
        // Get a line of input from the user
        cout << "Input data or STOP: ";
        getline(cin, input);
        
        // Write the line of input to the file (unless the user entered STOP,
        // then save the file and continue)
        if (input != "STOP")
        {
            file << input << endl;
        }
    }
    while (input != "STOP");
}

void modifyFile()
{
    // Get the name of the file from the user
    cout << "Enter the name of the file: ";
    string fileName;
    cin >> fileName;
    cin.ignore(100, '\n');
    
    // Ask the user if they want to append or overwrite the file, and get their choice
    cout << "Do you want to append to the file instead of overwriting? (y/n) ";
    string oa;
    cin >> oa;
    cin.ignore(100, '\n');
    
    // Initially we'll use overwrite mode...
    ios::openmode openMode = ios::out;
    
    // If the user wanted to append, however, add the append flag to do so
    if (oa == "y" || oa == "yes")
    {
        openMode |= ios::app;
    }
    
    string input;
    
    // Create a file stream to open the specified file
    fstream file(fileName.c_str(), openMode);
    do
    {
        // Get a line of input from the user
        cout << "Input data or STOP: ";
        getline(cin, input);
        
        // Write the line of input to the file (unless the user entered STOP,
        // then save the file and continue)
        if (input != "STOP")
        {
            file << input << endl;
        }
    }
    while (input != "STOP");
}

string displayFile()
{
    // Get the name of the file from the user
    cout << "Enter the name of the file: ";
    string fileName;
    cin >> fileName;
    
    string line;
    
    // Create a file stream to open the specified file
    fstream file(fileName.c_str(), ios::in);
    
    // While we are not at the end of the file, get a line and display it
    while (!file.eof())
    {
        getline(file, line);
        cout << line << endl;
    }
    
    // Return the name of the file we displayed
    return fileName;
}

void deleteFile()
{
    // Display the file before deleting it
    string fileName = displayFile();
    
    // Ask the user whether they are certain they want to delete the file
    cout << "Are you sure you want to delete the file? (y/n) ";
    string choice;
    cin >> choice;
    
    // If they said yes, delete it
    if (choice == "y" || choice == "yes")
    {
        remove(fileName.c_str());
    }
}