package HW05;

/**
 * Represents a weekly.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename Weekly.java
 */
public class Weekly extends Periodical
{
	/**
	 * The number of articles in the weekly.
	 */
	private int articleCount;
	
	/**
	 * Initializes a new instance of the {@link Weekly} class.
	 */
	public Weekly()
	{
		super();
	}
	
	/**
	 * Initializes a new instance of the {@link Weekly} class.
	 * @param title The title of the weekly.
	 * @param pageCount The number of pages in the weekly.
	 * @param coverType The cover type of the weekly.
	 * @param articleCount The number of articles in the weekly.
	 */
	public Weekly(String title, int pageCount, CoverType coverType, int articleCount)
	{
		super(title, pageCount, coverType);
		this.setArticleCount(articleCount);
	}

	/**
	 * Gets the number of articles in the weekly.
	 * @return The number of articles in the weekly.
	 */
	public int getArticleCount()
	{
		return this.articleCount;
	}

	/**
	 * Sets the number of articles in the weekly.
	 * @param articleCount The number of articles in the weekly.
	 */
	public void setArticleCount(int articleCount)
	{
		this.articleCount = articleCount;
	}
	
	/**
	 * Returns a string representation of the weekly.
	 */
	@Override
	public String toString()
	{
		return super.toString() + "Articles: " + this.getArticleCount() + "\n";
	}
}
