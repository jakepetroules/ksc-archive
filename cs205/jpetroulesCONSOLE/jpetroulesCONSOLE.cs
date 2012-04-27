// CONSOLE
// Author - Jake Petroules
// 2010-08-31
// This program prints out some basic information about its author and the course it was written for.

using System;
using System.Globalization;
using System.Windows.Forms;

namespace CS205F10
{
    class jpetroulesCONSOLE
    {
        static void Main()
        {
            Console.WriteLine("Jake Petroules");
            Console.WriteLine("CS205-01 Fall 2010");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("CONSOLE");
            Console.WriteLine(SystemInformation.ComputerName);
            Console.Write("Press [Enter] to quit");
            Console.Read();
        }
    }
}