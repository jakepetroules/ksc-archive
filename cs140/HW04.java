/**
 * Jake Petroules	CS140-04	Filename: HW04.java
 * This program prompts for the user's first and last name and generates a user
 * ID using the first character of the first name, the first five characters of
 * the last name, and a random number from to 10 to 99 inclusive.
 */

package HW04;

import java.util.Random;
import java.util.Scanner;

public class HW04
{
	public static void main(String[] args)
	{
		// Print the instruction message
		System.out.println("This program prompts for the user's first and last name and generates a user ID "
				+ "using the first character of the first name, the first five characters of the last name, "
				+ "and a random number from to 10 to 99 inclusive.");

		// Instantiate classes
		Scanner scan = new Scanner(System.in);
		Random generator = new Random();

		// Prompts the user for their first name and obtains it
		System.out.println("Please enter your first name: ");
		String firstName = scan.next();

		// Prompts the user for their last name and obtains it
		System.out.println("Please enter your last name: ");
		String lastName = scan.next();

		// Generates the user ID
		String userID = firstName.charAt(0) + lastName.substring(0, 5) + (generator.nextInt(90) + 10);

		// Print the generated ID, making certain it is in lower case
		System.out.println("The generated user ID was: " + userID.toLowerCase());
	}
}
