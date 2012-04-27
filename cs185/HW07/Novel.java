package HW07;

/**
 * Represents a novel.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename Novel.java
 */
public class Novel extends Book
{
	/**
	 * The classification of the novel.
	 */
	private Classification classification;
	
	/**
	 * Initializes a new instance of the {@link Novel} class.
	 */
	public Novel()
	{
		super();
	}
	
	/**
	 * Initializes a new instance of the {@link Novel} class.
	 * @param title The title of the novel.
	 * @param pageCount The number of pages in the novel.
	 * @param chapterCount The number of chapters in the novel.
	 * @param classification The classification of the novel.
	 */
	public Novel(String title, int pageCount, int chapterCount, Classification classification)
	{
		super(title, pageCount, chapterCount);
		this.setClassification(classification);
	}

	/**
	 * Gets the classification of the novel.
	 * @return The classification of the novel.
	 */
	public Classification getClassification()
	{
		return this.classification;
	}

	/**
	 * Sets the classification of the novel.
	 * @param classification The classification of the novel.
	 */
	public void setClassification(Classification classification)
	{
		this.classification = classification;
	}
	
	/**
	 * Returns a string representation of the novel.
	 */
	@Override
	public String toString()
	{
		return super.toString() + "Classification: " + this.getClassification() + "\n";
	}
}
