package HW10;

import java.io.*;

/**
 * Allows the user to participate in time travel.
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename HW10.java
 */
public class HW10
{
	public static void main(String[] args) throws IOException
	{
		System.out.println("How old are you?");
		TimeVehicle.travel(getAge());
	}
	
	/**
	 * Prompts the user for their age and returns the result.
	 */
	private static int getAge() throws IOException
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
		while (age == -1 || age < 0 || age > 100);
		
		return age;
	}
}
