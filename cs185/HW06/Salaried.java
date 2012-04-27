package HW06;

import java.math.*;
import java.text.*;

/**
 * Represents a salaried employee.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename Salaried.java
 */
public class Salaried extends Employee
{
	/**
	 * Initializes a new instance of the {@link Salaried} class.
	 * @param rate The payment rate for the employee.
	 * @param name The name of the employee.
	 * @param department The name of the department the employee works in.
	 * @param age The employee's age in years.
	 */
	public Salaried(BigDecimal rate, String name, String department, int age)
	{
		super(rate, name, department, age);
	}
	
	/**
	 * Calculates the salaried employee's weekly pay.
	 */
	@Override
	public BigDecimal pay()
	{
		// Salaried employees have a rate equal to their annual pay, so we
		// divide by 52 (number of weeks in a year) to get their weekly pay
		return this.getRate().divide(BigDecimal.valueOf(52).setScale(2), RoundingMode.FLOOR);
	}
	
	/**
	 * Returns a string representation of the salaried employee.
	 */
	@Override
	public String toString()
	{
		NumberFormat format = NumberFormat.getCurrencyInstance();
		return super.toString() + "\nAnnual pay: " + format.format(super.pay()) + "\nWeekly pay: " + format.format(this.pay());
	}
}
