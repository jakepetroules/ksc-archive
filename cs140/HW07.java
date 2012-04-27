package HW07;

/**
 * Jake Petroules CS140-04 Filename: HW07.java
 * This program will print the first few verses of the traveling song "One Hundred Bottles of Beer".
 */

import java.util.Scanner;

public class HW07
{
	public static void main(String[] args)
	{
		// Explain what the program does
		System.out.println("This program will print the first few verses of the traveling song \"One Hundred Bottles of Beer\".");
		
		// Ask the user how many verses of the song they would like to see
		System.out.print("How many verses would you like the program to print? ");
		
		// Create a scanner object and get the answer from the user
		Scanner scan = new Scanner(System.in);
		int numberOfVerses = scan.nextInt();
		
		// Make sure the user does not enter a number outside the range 1 to 100
		// If they do, keep asking them until they enter a proper value
		while (numberOfVerses < 1 || numberOfVerses > 100)
		{
			System.out.println("Please enter a number in the range 1 to 100: ");
			numberOfVerses = scan.nextInt();
		}
		
		// Loop through the number of verses the user wanted, printing the appropriate lines for each
		for (int i = 100; i > 100 - numberOfVerses; i--)
		{
			System.out.println(i + " bottles of beer on the wall");
			System.out.println(i + " bottles of beer");
			System.out.println("If one of those bottles should happen to fall");
			
			// Check if there are no more bottles left and output the appropriate statement
			if (i - 1 == 0)
			{
				System.out.println("No more bottles of beer on the wall");
				System.out.println("Go to the store and buy some more");
			}
			else
			{
				// Otherwise print the normal line
				System.out.println((i - 1) + " bottles of beer on the wall");
			}
		}
	}
}
