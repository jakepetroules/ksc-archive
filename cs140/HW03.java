/*
 * Jake Petroules	CS140-04	Filename: HW03.java
 * This program reads a monetary amount and determines the fewest number
 * of each bill and coin needed to represent that amount (starting with
 * the highest, using a ten dollar bill as the maximum).
 */

package HW03;

import java.text.NumberFormat;
import java.util.Scanner;

public class HW03
{
	private static final double TEN_DOLLAR_BILL_VALUE = 10.00;
	
	private static final double FIVE_DOLLAR_BILL_VALUE = 5.00;
	
	private static final double ONE_DOLLAR_BILL_VALUE = 1.00;
	
	private static final double QUARTER_VALUE = 0.25;
	
	private static final double DIME_VALUE = 0.10;
	
	private static final double NICKEL_VALUE = 0.05;
	
	private static final double PENNY_VALUE = 0.01;
	
	public static void main(String[] args)
	{
		System.out.println("This program reads a monetary amount and determines the fewest number " +
				"of each bill and coin needed to represent that amount (starting with " +
				"the highest, using a ten dollar bill as the maximum).");
		System.out.println("Please note that this program uses doubles for calculation, so results " +
				"may be slightly inaccurate in some cases. This problem could be solved by using the BigDecimal class.");
		
		// Create a Scanner object to get input from the user
		Scanner scan = new Scanner(System.in);
		
		// Ask for and obtain the value of the money
		System.out.println("Enter the amount of money: ");
		double originalMoneyValue = scan.nextDouble();
		
		// Copy the original value to a new variable we will decrement during calculation
		double moneyValue = originalMoneyValue;
		
		// Obtain the number of ten dollar bills needed and subtract the value of those bills from the money value
		long tenDollarBillCount = (long)((moneyValue - (moneyValue % TEN_DOLLAR_BILL_VALUE)) / TEN_DOLLAR_BILL_VALUE);
		moneyValue = moneyValue - (tenDollarBillCount * TEN_DOLLAR_BILL_VALUE);
		
		// Obtain the number of five dollar bills needed and subtract the value of those bills from the money value
		long fiveDollarBillCount = (long)((moneyValue - (moneyValue % FIVE_DOLLAR_BILL_VALUE)) / FIVE_DOLLAR_BILL_VALUE);
		moneyValue = moneyValue - (fiveDollarBillCount * FIVE_DOLLAR_BILL_VALUE);
		
		// Obtain the number of one dollar bills needed and subtract the value of those bills from the money value
		long oneDollarBillCount = (long)((moneyValue - (moneyValue % ONE_DOLLAR_BILL_VALUE)) / ONE_DOLLAR_BILL_VALUE);
		moneyValue = moneyValue - (oneDollarBillCount * ONE_DOLLAR_BILL_VALUE);
		
		// Obtain the number of quarters needed and subtract the value of those coins from the money value
		long quarterCount = (long)((moneyValue - (moneyValue % QUARTER_VALUE)) / QUARTER_VALUE);
		moneyValue = moneyValue - (quarterCount * QUARTER_VALUE);
		
		// Obtain the number of quarters needed and subtract the value of those coins from the money value
		long dimeCount = (long)((moneyValue - (moneyValue % DIME_VALUE)) / DIME_VALUE);
		moneyValue = moneyValue - (dimeCount * DIME_VALUE);
		
		// Obtain the number of quarters needed and subtract the value of those coins from the money value
		long nickelCount = (long)((moneyValue - (moneyValue % NICKEL_VALUE)) / NICKEL_VALUE);
		moneyValue = moneyValue - (nickelCount * NICKEL_VALUE);
		
		// Obtain the number of quarters needed and subtract the value of those coins from the money value
		long pennyCount = (long)((moneyValue - (moneyValue % PENNY_VALUE)) / PENNY_VALUE);
		moneyValue = moneyValue - (pennyCount * PENNY_VALUE);
		
		// Get a formatter object to format the monetary amount entered by the user
		NumberFormat currencyFormatter = NumberFormat.getCurrencyInstance();
		
		// Output the results
		System.out.println("The fewest numbers of each bill and coin needed to represent the value you entered (" + currencyFormatter.format(originalMoneyValue) + ") are:");
		System.out.println(tenDollarBillCount + " ten dollar bills");
		System.out.println(fiveDollarBillCount + " five dollar bills");
		System.out.println(oneDollarBillCount + " one dollar bills");
		System.out.println(quarterCount + " quarters");
		System.out.println(dimeCount + " dimes");
		System.out.println(nickelCount + " nickels");
		System.out.println(pennyCount + " pennies");
	}
}
