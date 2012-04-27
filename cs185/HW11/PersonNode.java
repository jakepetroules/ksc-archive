package HW11;

/**
 * Represents a linked list node encapsulating details about a person.
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename HW11.java
 */
public class PersonNode extends NodeBase
{
	/**
	 * The person's name.
	 */
	private String name;
	
	/**
	 * The person's age.
	 */
	private int age;
	
	/**
	 * Initializes a new instance of the {@link PersonNode} class.
	 * @param name The person's name.
	 * @param age The person's age.
	 */
	public PersonNode(String name, int age)
	{
		super();
		
		if (name == null || name.isEmpty())
		{
			throw new IllegalArgumentException("name is null.");
		}
		
		if (age < 0)
		{
			throw new IllegalArgumentException("age is less than 0.");
		}
		
		this.name = name;
		this.age = age;
	}
	
	/**
	 * Gets the person's name.
	 * @return The person's name.
	 */
	public String getName()
	{
		return this.name;
	}

	/**
	 * Sets the person's name.
	 * @param name The person's name.
	 */
	public void setName(String name)
	{
		this.name = name;
	}

	/**
	 * Gets the person's age.
	 * @return The person's age.
	 */
	public int getAge()
	{
		return this.age;
	}

	/**
	 * Sets the person's age.
	 * @param age The person's age.
	 */
	public void setAge(int age)
	{
		this.age = age;
	}
	
	public String toString()
	{
		return " Name: " + this.name + ", Age: " + this.age + "\n";
	}
}
