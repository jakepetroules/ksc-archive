package HW05;

/**
 * Represents a biography.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename Biography.java
 */
public class Biography extends Book
{
	/**
	 * The subject of the book.
	 */
	private String subject;
	
	/**
	 * Initializes a new instance of the {@link Biography} class.
	 */
	public Biography()
	{
		super();
	}
	
	/**
	 * Initializes a new instance of the {@link Biography} class.
	 * @param title The title of the biography.
	 * @param pageCount The number of pages in the biography.
	 * @param chapterCount The number of chapters in the biography.
	 * @param subject The subject of the book.
	 */
	public Biography(String title, int pageCount, int chapterCount, String subject)
	{
		super(title, pageCount, chapterCount);
		this.setSubject(subject);
	}

	/**
	 * Gets the subject of the book.
	 * @return The subject of the book.
	 */
	public String getSubject()
	{
		return this.subject;
	}

	/**
	 * Sets the subject of the book.
	 * @param subject The subject of the book.
	 */
	public void setSubject(String subject)
	{
		this.subject = subject;
	}
	
	/**
	 * Returns a string representation of the biography.
	 */
	@Override
	public String toString()
	{
		return super.toString() + "Subject: " + this.getSubject() + "\n";
	}
}
