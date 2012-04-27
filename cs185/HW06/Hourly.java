package HW06;

import java.math.*;
import java.text.*;

/**
 * Represents an hourly employee.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename Hourly.java
 */
public class Hourly extends Employee
{
	/**
	 * The number of hours the employee worked.
	 */
	private int hoursWorked;
	
	/**
	 * Initializes a new instance of the {@link Hourly} class.
	 * @param rate The payment rate for the employee.
	 * @param name The name of the employee.
	 * @param department The name of the department the employee works in.
	 * @param age The employee's age in years.
	 * @param hoursWorked The number of hours the employee worked.
	 */
	public Hourly(BigDecimal rate, String name, String department, int age, int hoursWorked)
	{
		super(rate, name, department, age);
		this.setHoursWorked(hoursWorked);
	}

	/**
	 * Gets the number of hours the employee worked.
	 * @return The number of hours the employee worked.
	 */
	public int getHoursWorked()
	{
		return this.hoursWorked;
	}

	/**
	 * Sets the number of hours the employee worked.
	 * @param hoursWorked The number of hours the employee worked.
	 */
	public void setHoursWorked(int hoursWorked)
	{
		this.hoursWorked = hoursWorked;
	}
	
	/**
	 * Calculates the hourly employee's weekly pay.
	 */
	@Override
	public BigDecimal pay()
	{
		// Get the number of overtime hours the employee worked
		int extraHours = this.getHoursWorked() - 40;
		
		// This'll store the pay for their overtime hours only
		BigDecimal overtimePay = BigDecimal.valueOf(0);
		
		// If they worked overtime...
		if (extraHours > 0)
		{
			// ...multiply their rate by 1.5 and then by the number of extra hours they worked
			overtimePay = this.getRate().multiply(BigDecimal.valueOf(1.5)).multiply(BigDecimal.valueOf(extraHours));
		}
		
		// Multiply their hourly rate by the total hours worked minus the extra hours, then add their overtime pay (if any) and return
		return this.getRate().multiply(BigDecimal.valueOf(this.getHoursWorked() - extraHours)).add(overtimePay);
	}
	
	/**
	 * Returns a string representation of the hourly employee.
	 */
	@Override
	public String toString()
	{
		NumberFormat format = NumberFormat.getCurrencyInstance();
		return super.toString() + "\nAnnual pay: " + format.format(super.pay()) + "\nWeekly pay: " + format.format(this.pay());
	}
}
