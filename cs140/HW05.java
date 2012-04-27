package HW05;

/**
 * Jake Petroules CS140-04 Filename: HW05.java
 * This program determines and prints the number of odd, even, and zero digits in an integer value read from
 * the keyboard.
 */

import java.util.Scanner;

public class HW05
{
	public static void main(String[] args)
	{
		Scanner scan = new Scanner(System.in);

		System.out.print("Please enter an integer value to find the number of odd, even and zero digits in: ");

		// Get the value from the user
		int value = scan.nextInt();

		// The amounts of each type of digit
		int numberOdd = 0;
		int numberEven = 0;
		int numberZero = 0;

		// Loop until no digits are left - we count from right to left
		while (value > 0)
		{
			// Get the end digit
			int digit = value % 10;

			// Chop off the ending digit
			value = value / 10;

			if (digit == 0)
			{
				numberZero++;
			}
			else if (digit % 2 == 0)
			{
				numberEven++;
			}
			else if (digit % 2 != 0)
			{
				numberOdd++;
			}
		}

		System.out.println("The number you entered was: " + value);

		System.out.println("There were:");
		System.out.println(numberOdd + " odd digits");
		System.out.println(numberEven + " even digits");
		System.out.println(numberZero + " zero digits");
	}
}
