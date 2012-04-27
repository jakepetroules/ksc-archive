package HW05;

/**
 * This program functions as a test suite for a set of classes comprising a
 * library item class hierarchy.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename HW05.java
 */
public class HW05
{
	public static void main(String[] args)
	{
		System.out.println("This program functions as a test suite for a set of classes comprising a library item class hierarchy.");
		System.out.println();

		System.out.println("Instantiating and printing a biography:");
		System.out.println(new Biography("Jake Petroules - The Story", 1024, 64, "Life Stories"));

		System.out.println("Instantiating and printing a novel:");
		System.out.println(new Novel("The Adventures of Jake", 439, 27, Classification.NonFiction));

		System.out.println("Instantiating and printing a weekly:");
		System.out.println(new Weekly("Petroules Enterprises Weekly", 107, CoverType.Loose, 27));

		System.out.println("Instantiating and printing a textbook:");
		System.out.println(new MyText("Petroules Enterprises Software Engineering 101", 9001, 256));
	}
}
