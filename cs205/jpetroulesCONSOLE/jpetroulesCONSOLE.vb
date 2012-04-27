' CONSOLE
' Author - Jake Petroules
' 2010-08-31
' This program prints out some basic information about its author and the course it was written for.

Option Explicit On
Option Strict On

Imports System
Imports System.Globalization
Imports System.Windows.Forms

Namespace CS205F10
    Module jpetroulesCONSOLE
        Sub Main()
            Console.WriteLine("Jake Petroules")
            Console.WriteLine("CS205-01 Fall 2010")
            Console.WriteLine(DateTime.Now)
            Console.WriteLine("CONSOLE")
            Console.WriteLine(SystemInformation.ComputerName)
            Console.Write("Press [Enter] to quit")
            Console.Read()
        End Sub
    End Module
End Namespace