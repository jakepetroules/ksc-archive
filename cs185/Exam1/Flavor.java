/**
 * Represents an ice cream flavor.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename Flavor.java
 */
public class Flavor
{
	/**
	 * The number of this flavor.
	 */
	private int flavnum;
	
	/**
	 * The name of this flavor.
	 */
	private String flavor;
	
	/**
	 * The number of ice cream cones of this flavor that are available.
	 */
	private int qty;
	
	/**
	 * Initializes a new instance of the {@link Flavor} class.
	 * @param flavnum The number of this flavor.
	 * @param flavor The name of this flavor.
	 * @param qty The number of ice cream cones of this flavor that are available.
	 */
	public Flavor(int flavnum, String flavor, int qty)
	{
		this.flavnum = flavnum;
		this.flavor = flavor;
		this.qty = qty;
	}
	
	/**
	 * Returns a string representation of this flavor.
	 */
	public String toString()
	{
		return "Flavor Number: " + this.flavnum + "\tFlavor " + this.flavor + "\tQty: " + this.qty;
	}
}
