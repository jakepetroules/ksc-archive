package HW07;

/**
 * Represents a textbook.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename MyText.java
 */
public class MyText extends Book
{
	/**
	 * Initializes a new instance of the {@link MyText} class.
	 */
	public MyText()
	{
		super();
	}
	
	/**
	 * Initializes a new instance of the {@link MyText} class.
	 * @param title The title of the textbook.
	 * @param pageCount The number of pages in the textbook.
	 * @param chapterCount The number of chapters in the textbook.
	 */
	public MyText(String title, int pageCount, int chapterCount)
	{
		super(title, pageCount, chapterCount);
	}
	
	/**
	 * Returns a string representation of the textbook.
	 */
	@Override
	public String toString()
	{
		return super.toString();
	}
}
