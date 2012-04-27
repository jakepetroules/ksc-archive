package HW06;

/**
 * Jake Petroules CS140-04 Filename: HW06.java
 * This program simulates a slot machine. The program will roll 3 numbers. If all 3 are the same, you win.
 * If two are the same, you get a free spin. After each round you will be prompted if you want to continue playing.
 */

import java.util.Random;
import java.util.Scanner;

public class HW06
{
	public static void main(String[] args)
	{
		System.out.println("This program simulates a slot machine. The program will roll 3 numbers. If all 3 are the same, you win. " +
				"If two are the same, you get a free spin. After each round you will be prompted if you want to continue playing.");

		// Create a scanner object to get input from the user
		Scanner scan = new Scanner(System.in);

		// Create a random object to generate random numbers
		Random generator = new Random();

		// Whether the user wants to play again
		boolean playAgain = false;

		do
		{
			// Generate the numbers
			int number1 = generator.nextInt(10);
			int number2 = generator.nextInt(10);
			int number3 = generator.nextInt(10);

			// Check if the numbers are all the same and store the result in a variable
			boolean allTheSame = number1 == number2 && number2 == number3;
			
			// Check if at least two numbers are the same and store the result in a variable
			boolean twoTheSame = number1 == number2 || number2 == number3 || number1 == number3;
			
			// Check if all the numbers are different and store the result in a variable
			boolean noneTheSame = number1 != number2 && number2 != number3 && number1 != number3;

			// Print the rolled numbers to the screen
			System.out.println("Your numbers are:");
			System.out.println(number1 + "\t" + number2 + "\t" + number3);

			// Check if all of the numbers were the same, or none were
			if (allTheSame || noneTheSame)
			{
				// If all the numbers were the same, tell the user they are a winner
				if (allTheSame)
				{
					System.out.println("You are a winner!");
				}
				
				// Prompt the user if they want to play again - this will execute whether
				// all numbers were the same (winner) or none were the same (loser)
				System.out.println("Do you want to play again? Enter y for yes: ");
				playAgain = scan.next().equalsIgnoreCase("y");
			}
			else if (twoTheSame)
			{
				// If two numbers were the same, the user gets a free spin
				System.out.println("You get a free spin!");
				playAgain = true;
			}
		}
		while (playAgain);
	}
}
