package HW06;

import java.math.*;

/**
 * Represents a generic employee.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename Employee.java
 */
public abstract class Employee implements SortAge
{
	/**
	 * The payment rate for the employee.
	 */
	private BigDecimal rate;
	
	/**
	 * The name of the employee.
	 */
	private String name;
	
	/**
	 * The name of the department the employee works in.
	 */
	private String department;
	
	/**
	 * The employee's age in years.
	 */
	private int age;
	
	/**
	 * Initializes a new instance of the {@link Employee} class.
	 * @param rate The payment rate for the employee.
	 * @param name The name of the employee.
	 * @param department The name of the department the employee works in.
	 * @param age The employee's age in years.
	 */
	protected Employee(BigDecimal rate, String name, String department, int age)
	{
		this.setRate(rate);
		this.setName(name);
		this.setDepartment(department);
		this.setAge(age);
	}
	
	/**
	 * Gets the payment rate for the employee (annual rate for salaried employees, hourly rate for hourly employees).
	 * @return The payment rate for the employee.
	 */
	public BigDecimal getRate()
	{
		return this.rate.setScale(2);
	}

	/**
	 * Sets the payment rate for the employee.
	 * @param rate The payment rate for the employee.
	 */
	public void setRate(BigDecimal rate)
	{
		this.rate = rate.setScale(2);
	}

	/**
	 * Gets the name of the employee.
	 * @return The name of the employee.
	 */
	public String getName()
	{
		return this.name;
	}

	/**
	 * Sets the name of the employee.
	 * @param name The name of the employee.
	 */
	public void setName(String name)
	{
		this.name = name;
	}

	/**
	 * Gets the name of the department the employee works in.
	 * @return The name of the department the employee works in.
	 */
	public String getDepartment()
	{
		return this.department;
	}

	/**
	 * Sets the name of the department the employee works in.
	 * @param department The name of the department the employee works in.
	 */
	public void setDepartment(String department)
	{
		this.department = department;
	}

	/**
	 * Calculates the employee's annual pay.
	 */
	public BigDecimal pay()
	{
		if (this instanceof Salaried)
		{
			// Salaried employees have a rate equal to their annual pay so we just return that
			return this.getRate();
		}
		else if (this instanceof Hourly)
		{
			// Hourly employees have a rate equal to their hourly pay, so we multiply it by the
			// number of hours they worked and then by 52, which is the number of weeks in a year
			// and return the result
			return this.getRate().multiply(BigDecimal.valueOf(((Hourly)this).getHoursWorked())).multiply(BigDecimal.valueOf(52));
		}
		else
		{
			return BigDecimal.valueOf(0);
		}
	}
	
	@Override
	public int compareAge(SortAge other)
	{
		return this.getAge() - other.getAge();
	}

	@Override
	public int getAge()
	{
		return this.age;
	}
	
	/**
	 * Sets the age.
	 * @param age The age.
	 */
	public void setAge(int age)
	{
		this.age = age;
	}
	
	/**
	 * Returns a string representation of the employee.
	 */
	@Override
	public String toString()
	{
		return "Name: " + this.getName() + "\nDepartment: " + this.getDepartment() + "\nAge: " + this.getAge();
	}
}
