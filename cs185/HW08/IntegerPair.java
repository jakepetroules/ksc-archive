package HW08;

/**
 * Represents a pair of two integers.
 * @author Jake Petroules
 * @course CS-185-01
 */
public class IntegerPair
{
	/**
	 * The first integer.
	 */
	private int num1;
	
	/**
	 * The second integer.
	 */
	private int num2;
	
	/**
	 * Initializes a new instance of the {@link IntegerPair} class.
	 */
	public IntegerPair()
	{
	}
	
	/**
	 * Initializes a new instance of the {@link IntegerPair} class.
	 * @param num1 The first integer.
	 * @param num2 The second integer.
	 */
	public IntegerPair(int num1, int num2)
	{
		this.setNum1(num1);
		this.setNum2(num2);
	}

	/**
	 * Gets the first integer.
	 * @return The first integer.
	 */
	public int getNum1()
	{
		return this.num1;
	}

	/**
	 * Sets the first integer.
	 * @param num1 The first integer.
	 */
	public void setNum1(int num1)
	{
		this.num1 = num1;
	}

	/**
	 * Gets the second integer.
	 * @return The second integer.
	 */
	public int getNum2()
	{
		return this.num2;
	}

	/**
	 * Sets the second integer.
	 * @param num2 The second integer.
	 */
	public void setNum2(int num2)
	{
		this.num2 = num2;
	}
	
	/**
	 * Gets the product of the encapsulated integers.
	 * @return The product of the encapsulated integers.
	 */
	public int product()
	{
		return this.getNum1() * this.getNum2();
	}
	
	/**
	 * Gets the quotient of the encapsulated integers.
	 * @return The quotient of the encapsulated integers.
	 */
	public int quotient()
	{
		return this.getNum1() / this.getNum2();
	}
	
	/**
	 * Gets the remainder of the division of the encapsulated integers.
	 * @return The remainder of the division of the encapsulated integers.
	 */
	public int remainder()
	{
		return this.getNum1() % this.getNum2();
	}
}
