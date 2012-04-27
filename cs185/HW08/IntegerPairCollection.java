package HW08;

/**
 * Represents a collection of {@link IntegerPair}s.
 * @author Jake Petroules
 * @course CS-185-01
 */
public class IntegerPairCollection extends CollectionBase<IntegerPair>
{
	/**
	 * Initializes a new instance of the {@link IntegerPairCollection} class.
	 */
	public IntegerPairCollection()
	{
	}
	
	/**
	 * Adds an integer pair to the collection.
	 * @param num1 The first integer.
	 * @param num2 The second integer.
	 */
	public void add(int num1, int num2)
	{
		this.add(new IntegerPair(num1, num2));
	}
}
