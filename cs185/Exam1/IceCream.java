/**
 * Represents an ice cream truck.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename IceCream.java
 */
public class IceCream
{
	/**
	 * The ice cream flavors present in the truck.
	 */
	private Flavor[] flavors;
	
	/**
	 * Initializes a new instance of the {@link IceCream} class.
	 */
	public IceCream()
	{
		this.flavors = new Flavor[12];
		this.makeSet();
	}
	
	/**
	 * Creates the set of ice cream flavors.
	 */
	public void makeSet()
	{
		for (int i = 1; i <= 12; i++)
		{
			if (i % 2 == 0 && i % 3 == 0)
			{
				// Any flavor number divisible by 2 AND 3 is vanilla chocolate
				this.flavors[i - 1] = new Flavor(i, "Vanilla Chocolate", i * 2);
			}
			else if (i % 2 == 0)
			{
				// Any flavor number divisible by 2 is vanilla
				this.flavors[i - 1] = new Flavor(i, "Vanilla", i * 2);
			}
			else if (i % 3 == 0)
			{
				// Any flavor number divisible by 3 is chocolate
				this.flavors[i - 1] = new Flavor(i, "Chocolate", i * 2);
			}
			else
			{
				// All others are strawberry...
				this.flavors[i - 1] = new Flavor(i, "Strawberry", i * 2);
			}
		}
	}
	
	/**
	 * Returns a string containing the set of ice cream flavors.
	 */
	public String printSet()
	{
		StringBuilder builder = new StringBuilder();
		
		for (int i = 0; i < this.flavors.length; i++)
		{
			builder.append(this.flavors[i] + "\n");
		}
		
		return builder.toString();
	}
}
