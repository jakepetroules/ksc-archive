package HW04;

import java.io.*;

/**
 * This program demonstrates reading the contents of a file into an array.
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename HW04.java
 */
public class HW04
{
	/**
	 * The name of the file to read the operating system data from.
	 */
	final static String FILE_NAME = "info_4.inp";
	
	/**
	 * The magic number of the operating system binary data file format.
	 */
	final static String MAGIC_NUMBER = "KSCHW04OSC";

	/**
	 * The first 10 operating systems in the data file.
	 */
	private static OperatingSystem[] operatingSystems = new OperatingSystem[10];

	public static void main(String[] args) throws IOException
	{
		System.out.println("This program prints the first 10 operating systems contained in the specified data file.");
		System.out.println();

		DataInputStream stream = new DataInputStream(new FileInputStream(FILE_NAME));
		try
		{
			if (stream.readUTF().equals(MAGIC_NUMBER))
			{
				int osCount = stream.readInt();
				for (int i = 0; i < osCount; i++)
				{
					OperatingSystem os = OperatingSystem.readFromStream(stream);
					if (i >= operatingSystems.length)
					{
						System.out.println("Array is full. Operating system was not added: " + os);
					}
					else
					{
						operatingSystems[i] = os;
					}
				}
			}
			else
			{
				error();
			}
		}
		catch (EOFException e)
		{
			error();
		}
		catch (UTFDataFormatException e)
		{
			error();
		}
		
		System.out.println();
		
		// Print the unsorted OS array
		System.out.println("Here are the first 10 operating systems that were contained in the file (unsorted):");
		System.out.println(new OperatingSystemCollection(operatingSystems));
		
		// Sort the OS array
		QuickSort.quicksort(operatingSystems);
		
		// Print the sorted OS array
		System.out.println("Here are the first 10 operating systems that were contained in the file (sorted by version name):");
		System.out.println(new OperatingSystemCollection(operatingSystems));
	}
	
	/**
	 * Displays an error message and terminates the program.
	 */
	public static void error()
	{
		System.out.println("The file was in an invalid format and reading cannot continue.");
		System.exit(1);
	}

	/**
	 * Writes test data to the file specified by {@link fileName}.
	 * @param fileName The name of the file to write to.
	 * @throws IOException An I/O exception occurs when writing the file.
	 */
	public static void writeTestFile(String fileName) throws IOException
	{
		OperatingSystemCollection coll = new OperatingSystemCollection();
		coll.add("Microsoft", "Windows", "6", "Vista");
		coll.add("Apple", "Macintosh OS X", "10.5", "Leopard");
		coll.add("Microsoft", "Windows", "5", "XP");
		coll.add("Petroules Enterprises", "Pneumonoultramicroscopicsilicovolcanoconiosis", "1", "Dihydrogen Monoxide");
		coll.add("Apple", "Macintosh OS X", "10.6", "Snow Leopard");
		coll.add("Canonical", "Ubuntu Linux", "9.1", "Karmic Koala");
		coll.add("Apple", "Macintosh OS X", "10.4", "Tiger");
		coll.add("Microsoft", "Windows", "7", "7");
		coll.add("Novell", "openSUSE", "11.2", "");
		coll.add("Canonical", "Ubuntu Linux", "10.04a2 LTS", "Lucid Lynx");
		coll.add("Canonical", "Ubuntu Linux", "9.04", "Jaunty Jackalope");
		coll.add("Oracle", "Solaris", "10", "");
		
		DataOutputStream out = new DataOutputStream(new FileOutputStream(fileName));
		out.writeUTF(MAGIC_NUMBER);
		out.writeInt(coll.size());
		for (int i = 0; i < coll.size(); i++)
		{
			coll.get(i).writeToStream(out);
		}
	}
}
