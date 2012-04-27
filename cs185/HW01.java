package HW01;

import java.io.*;

/**
 * This program will print verses of the traveling song
 * "One Hundred Bottles of Vodka".
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename HW01.java
 */
public class HW01
{
	public static void main(String[] args) throws IOException
	{
		// Explain what the program does
		System.out.println("This program will print the first few verses of the traveling song \"One Hundred Bottles of Vodka\".");

		// Ask the user how many verses of the song they would like to see
		System.out.print("How many verses would you like the program to print? ");

		// Get the answer from the user
		BufferedReader reader = null;
		int numberOfVerses;
		try
		{
			reader = new BufferedReader(new InputStreamReader(System.in));
			numberOfVerses = getInteger(reader);

			// Make sure the user does not enter a number outside the range 1 to 100
			// If they do, keep asking them until they enter a proper value
			while (numberOfVerses < 1 || numberOfVerses > 100)
			{
				System.out.println("Please enter a number in the range 1 to 100: ");
				numberOfVerses = getInteger(reader);
			}
		}
		finally
		{
			reader.close();
		}

		// Loop through the number of verses the user wanted, printing the appropriate lines for each
		for (int i = numberOfVerses; i > 0; i--)
		{
			System.out.println(i + " bottles of vodka on the wall");
			System.out.println(i + " bottles of vodka");
			System.out.println("If one of those bottles should happen to fall");

			// Check if there are no more bottles left and output the appropriate statement
			if (i - 1 == 0)
			{
				System.out.println("No more bottles of vodka on the wall");
				System.out.println("Go to the store and buy some more");
			}
			else
			{
				// Otherwise print the normal line
				System.out.println((i - 1) + " bottles of vodka on the wall");
			}
		}
	}

	/**
	 * Scans the next token of the input as an <code>int</code>.
	 * @param reader The {@link BufferedReader} used to read the input.
	 * @return The next token of the input as an <code>int</code>; -1 if the
	 * token retrieved did not match the pattern for the expected type.
	 */
	private static int getInteger(BufferedReader reader) throws IOException
	{
		try
		{
			return Integer.parseInt(reader.readLine());
		}
		catch (NumberFormatException e)
		{
			return -1;
		}
	}
}
