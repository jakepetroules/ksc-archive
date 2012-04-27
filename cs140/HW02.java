/*
 * Jake Petroules	CS140-04	Filename: HW02.java
 * This program determines the value of coins in a jar.
 */

package HW02;

import java.util.Scanner;

public class HW02
{
	/**
	 * The value of a quarter in decimal dollars.
	 */
	private static final float QUARTER_VALUE = 0.25f;
	
	/**
	 * The value of a dime in decimal dollars.
	 */
	private static final float DIME_VALUE = 0.10f;
	
	/**
	 * The value of a nickel in decimal dollars.
	 */
	private static final float NICKEL_VALUE = 0.05f;
	
	/**
	 * The value of a penny in decimal dollars.
	 */
	private static final float PENNY_VALUE = 0.01f;
	
	public static void main(String[] args)
	{
		// Tell the user what the program does
		System.out.println("This program determines the value of coins in a jar.\n");
		
		// We will add this to the beginning of each prompt for the number of coins of a particular type
		String prefix = "Please enter the number of ";
		
		// Create a Scanner object to get input from the user
		Scanner scan = new Scanner(System.in);
		
		// Ask for and obtain the number of quarters
		System.out.println(prefix + "quarters: ");
		int quarterCount = scan.nextInt();
		
		// Ask for and obtain the number of dimes
		System.out.println(prefix + "dimes: ");
		int dimeCount = scan.nextInt();
		
		// Ask for and obtain the number of nickels
		System.out.println(prefix + "nickels: ");
		int nickelCount = scan.nextInt();
		
		// Ask for and obtain the number of pennies
		System.out.println(prefix + "pennies: ");
		int pennyCount = scan.nextInt();
		
		// Add up the total value of all the coins...
		float dollarValue = (quarterCount * QUARTER_VALUE) + (dimeCount * DIME_VALUE) + (nickelCount * NICKEL_VALUE) + (pennyCount * PENNY_VALUE);
		
		// Print a message showing the number of each type of coin the user entered, and their added value
		System.out.println("The dollar value of your input (" +
				quarterCount + " quarters, " +
				dimeCount + " dimes, " +
				nickelCount + " nickels and " +
				pennyCount + " pennies) is $" +
				dollarValue);
	}
}
