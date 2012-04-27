package HW05;

/**
 * Represents a library item.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename LibraryItem.java
 */
public abstract class LibraryItem
{
	/**
	 * The title of the library item.
	 */
	private String title;
	
	/**
	 * The number of pages in the library item.
	 */
	private int pageCount;
	
	/**
	 * Initializes a new instance of the {@link LibraryItem} class.
	 */
	protected LibraryItem()
	{
	}
	
	/**
	 * Initializes a new instance of the {@link LibraryItem} class with the specified title and page count.
	 * @param title The title of the library item.
	 * @param pageCount The number of pages in the library item.
	 */
	protected LibraryItem(String title, int pageCount)
	{
		this.setTitle(title);
		this.setPageCount(pageCount);
	}

	/**
	 * Gets the title of the library item.
	 * @return The title of the library item.
	 */
	public String getTitle()
	{
		return this.title;
	}

	/**
	 * Sets the title of the library item.
	 * @param title The title of the library item.
	 */
	public void setTitle(String title)
	{
		this.title = title;
	}
	
	/**
	 * Gets the number of pages in the library item.
	 * @return The number of pages in the library item.
	 */
	public int getPageCount()
	{
		return this.pageCount;
	}

	/**
	 * Sets the number of pages in the library item.
	 * @param pageCount The number of pages in the library item.
	 */
	public void setPageCount(int pageCount)
	{
		this.pageCount = pageCount;
	}
	
	/**
	 * Returns a string representation of the library item.
	 */
	@Override
	public String toString()
	{
		return "Title: " + this.getTitle() + "\n" + "Pages: " + this.getPageCount() + "\n";
	}
}
