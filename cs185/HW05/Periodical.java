package HW05;

/**
 * Represents a periodical.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename Periodical.java
 */
public class Periodical extends LibraryItem
{
	/**
	 * The cover type of the periodical.
	 */
	private CoverType coverType;
	
	/**
	 * Initializes a new instance of the {@link Periodical} class.
	 */
	public Periodical()
	{
		super();
	}
	
	/**
	 * Initializes a new instance of the {@link Periodical} class.
	 * @param title The title of the periodical.
	 * @param pageCount The number of pages in the periodical.
	 * @param coverType The cover type of the periodical.
	 */
	public Periodical(String title, int pageCount, CoverType coverType)
	{
		super(title, pageCount);
		this.setCoverType(coverType);
	}

	/**
	 * Gets the cover type of the periodical.
	 * @return The cover type of the periodical.
	 */
	public CoverType getCoverType()
	{
		return this.coverType;
	}

	/**
	 * Sets the cover type of the periodical.
	 * @param coverType The cover type of the periodical.
	 */
	public void setCoverType(CoverType coverType)
	{
		this.coverType = coverType;
	}
	
	/**
	 * Returns a string representation of the periodical.
	 */
	@Override
	public String toString()
	{
		return super.toString() + "Cover Type: " + this.getPageCount() + "\n";
	}
}
