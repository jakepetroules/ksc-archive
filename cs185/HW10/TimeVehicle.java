package HW10;

import java.io.*;

/**
 * Represents a time vehicle that allows the user to travel through time!
 * @author Jake Petroules
 * @course CS-185-01
 * @filename TimeVehicle.java
 */
public class TimeVehicle
{
	/**
	 * Begins time traveling, saving the user's current age so they don't get stuck in a time warp.
	 * @param age The user's age.
	 */
	public static void travel(int age) throws IOException
	{
		System.out.println("How many years forward or backward do you want to travel? Enter a positive number to travel forwards, or a negative number to travel backwards.");
		travel(age, getYears(), 1);
		System.out.println("Thank you for participating in time travel!");
	}
	
	/**
	 * Continues time traveling with the specified age and number of years forward or backward, to travel.
	 * @param age The user's age.
	 * @param years The number of years to travel forward or backward.
	 * @param count The number of the current step.
	 */
	private static void travel(int age, int years, int count) throws IOException
	{
		int currentAge = age + years;
		int currentStep = count++;
		
		if (currentAge <= 0 || currentAge >= 100)
		{
			return;
		}
		
		System.out.println("What color is your house?");
		String houseColor = getHouseColor();
		
		System.out.println("Is your house in good condition or disrepair?");
		String houseCondition = getHouseCondition();
		
		System.out.println("How many years forward or backward do you want to travel? Enter a positive number to travel forwards, or a negative number to travel backwards.");
		travel(age, getYears(), count);
		
		System.out.println("#" + currentStep + ": When you were " + currentAge + ", your house was " + houseColor + " and in " + houseCondition);
	}
	
	/**
	 * Prompts the user for their house color and returns the result.
	 */
	private static String getHouseColor() throws IOException
	{
		BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
		return reader.readLine();
	}
	
	/**
	 * Prompts the user for their house condition and returns the result.
	 */
	private static String getHouseCondition() throws IOException
	{
		BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
		String houseCondition = "";
		do
		{
			houseCondition = reader.readLine();
			if (!houseCondition.equalsIgnoreCase("good condition") && !houseCondition.equalsIgnoreCase("disrepair"))
			{
				System.out.println("Please enter 'good condition' or 'disrepair' (without quotes).");
			}
		}
		while (!houseCondition.equalsIgnoreCase("good condition") && !houseCondition.equalsIgnoreCase("disrepair"));
		
		return houseCondition;
	}
	
	/**
	 * Prompts the user for the number of years to travel forward or backward in time and returns the result.
	 */
	private static int getYears() throws IOException
	{
		BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
		
		int age = -1;
		do
		{
			try
			{
				age = Integer.valueOf(reader.readLine());
			}
			catch (NumberFormatException e)
			{
				System.out.println("Not a number. Try again.");
			}
		}
		while (age == -1);
		
		return age;
	}
}
