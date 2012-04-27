package HW09;

import java.io.*;

/**
 * Demonstrates recursion with Fibonacci numbers.
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename HW09.java
 */
public class HW09
{
	public static void main(String[] args) throws IOException
	{
		System.out.println("This program calculates and outputs Fibonacci numbers.");
		System.out.println("Enter the maximum Fibonacci number to be calculated (range 3 to 1,836,311,903): ");
		
		BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
		int max = 0;
		do
		{
			try
			{
				max = Integer.valueOf(reader.readLine());
				
				if (max < 3 || max > 1836311903)
				{
					System.out.println("Not a valid number, try again!");
				}
			}
			catch (NumberFormatException e)
			{
				System.out.println("Not a valid number, try again!");
			}
		}
		while (max < 3 || max > 1836311903);
		
		Fibonacci fib = new Fibonacci(max, new PrintWriter("values.out"));
		
		System.out.println("Here are the numbers: ");
		System.out.println(1);
		System.out.println(1);
		fib.process();
		fib.getTarget().close();
	}
}
