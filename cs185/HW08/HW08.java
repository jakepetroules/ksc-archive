package HW08;

import java.io.*;
import java.util.*;

/**
 * Demonstrates exceptions.
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename HW08.java
 */
public class HW08
{
	public static void main(String[] args) throws FileNotFoundException
	{
		System.out.println("This program demonstrates exceptions.");
		System.out.println("The program's output will be written to the file: values.out");

		// This would be considered very poorly written in a real program,
		// but here we only have one preset input file so I'll be lazy
		IntegerPairCollection pairs = new IntegerPairCollection();
		Scanner scanner = new Scanner(new File("values.inp"));
		while (scanner.hasNextInt())
		{
			pairs.add(scanner.nextInt(), scanner.nextInt());
		}
		
		scanner.close();

		GridFormatter formatter = new GridFormatter("Integer value 1", "Integer value 2", "Product", "Quotient", "Remainder");

		for (int i = 0; i < pairs.size(); i++)
		{
			IntegerPair pair = pairs.get(i);
			
			String quotient = "";
			try
			{
				quotient = String.valueOf(pair.quotient());
			}
			catch (ArithmeticException e)
			{
				quotient = "Error: " + e.getMessage();
			}
			
			String remainder = "";
			try
			{
				remainder = String.valueOf(pair.remainder());
			}
			catch (ArithmeticException e)
			{
				remainder = "Error: " + e.getMessage();
			}

			formatter.addRow(pair.getNum1(), pair.getNum2(), pair.product(), quotient, remainder);
		}

		PrintWriter output = new PrintWriter("values.out");
		output.println("This file contains the products, quotients and division-remainders of the numbers contained in the input file.");
		output.print(formatter.toString());
		output.close();
	}
}
