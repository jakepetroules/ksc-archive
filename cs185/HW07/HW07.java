package HW07;

/**
 * Demonstrates polymorphism.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename HW07.java
 */
public class HW07
{
	public static void main(String[] args)
	{
		System.out.println("This program demonstrates polymorphism.\n");
		
		LibraryItem[] bookshelf = new LibraryItem[6];
		bookshelf[0] = new Novel("The Greatest Story Ever Told", 8390, 933, Classification.Fantasy);
		bookshelf[1] = new Novel("The One Pizza to Rule Them All", 500, 14, Classification.Horror);
		bookshelf[2] = new MyText("Why C# is better than Java", 1936, 45);
		bookshelf[3] = new MyText("Using C++ and Qt to write programs better than those written in Java", 1500, 38);
		bookshelf[4] = new Weekly("Software Engineering at Petroules Enterprises", 125, CoverType.Loose, 13);
		bookshelf[5] = new Weekly("Industrial Chemistry", 104, CoverType.Bound, 29);
		
		System.out.println("The bookshelf has:\n");
		for (int i = 0; i < bookshelf.length; i++)
		{
			System.out.println(bookshelf[i]);
		}
		
		Sorting.selectionsort(bookshelf);
		System.out.println("The bookshelf has been sorted by page count!\n");
		
		System.out.println("The bookshelf now has:\n");
		for (int i = 0; i < bookshelf.length; i++)
		{
			System.out.println(bookshelf[i]);
		}
	}
}
