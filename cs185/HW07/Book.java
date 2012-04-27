package HW07;

/**
 * Represents a book.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename Book.java
 */
public class Book extends LibraryItem
{
	/**
	 * The number of chapters in the book.
	 */
	private int chapterCount;
	
	/**
	 * Initializes a new instance of the {@link Book} class.
	 */
	public Book()
	{
		super();
	}
	
	/**
	 * Initializes a new instance of the {@link Book} class with the specified title, page count and chapter count.
	 * @param title The title of the book.
	 * @param pageCount The number of pages in the book.
	 * @param chapterCount The number of chapters in the book.
	 */
	public Book(String title, int pageCount, int chapterCount)
	{
		super(title, pageCount);
		this.setChapterCount(chapterCount);
	}
	
	/**
	 * Gets the number of chapters in the book.
	 * @return The number of chapters in the book.
	 */
	public int getChapterCount()
	{
		return this.chapterCount;
	}

	/**
	 * Sets the number of chapters in the book.
	 * @param chapterCount The number of chapters in the book.
	 */
	public void setChapterCount(int chapterCount)
	{
		this.chapterCount = chapterCount;
	}
	
	/**
	 * Returns a string representation of the book.
	 */
	@Override
	public String toString()
	{
		return super.toString() + "Chapters: " + this.getChapterCount() + "\n";
	}
}
