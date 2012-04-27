package Exam01;

import java.util.Scanner;

/**
 * Jake Petroules
 * CS140-04, 2009-10-01
 * Calculates a student's average grade.
 */
public class Exam01
{
	public static void main(String[] args)
	{
		System.out.println("This program calculates average grade.");
		Scanner scan = new Scanner(System.in);
		System.out.print("Enter student ID: ");
		int studentID = scan.nextInt();
		System.out.print("Enter grade 1: ");
		int grade1 = scan.nextInt();
		System.out.print("Enter grade 2: ");
		int grade2 = scan.nextInt();
		// Calculate average
		float average = (grade1 + grade2) / 2.0f;
		System.out.println("ID number\tGrade 1\tGrade 2" +
				"\tAverage");
		System.out.println(studentID + "\t\t" + grade1 +
				"\t" + grade2 + "\t" + average);
	}
}