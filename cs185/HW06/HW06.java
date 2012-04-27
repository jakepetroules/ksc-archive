package HW06;

import java.math.*;

/**
 * Demonstrates inheritance and polymorphism using employee classes.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename HW06.java
 */
public class HW06
{
	public static void main(String[] args)
	{
		Employee[] employees = new Employee[6];
		
		employees[0] = new Salaried(BigDecimal.valueOf(50000), "James Green", "Sales", 32);
		employees[1] = new Salaried(BigDecimal.valueOf(20000), "Joe Brown", "Maintenance", 24);
		employees[2] = new Salaried(BigDecimal.valueOf(2147483647), "Jake Petroules", "Management", 18);
		
		// Allison worked overtime
		employees[3] = new Hourly(BigDecimal.valueOf(13), "Allison Jones", "Billing", 21, 45);
		employees[4] = new Hourly(BigDecimal.valueOf(22), "Bob Samson", "Security", 29, 39);
		employees[5] = new Hourly(BigDecimal.valueOf(15), "Ashley Gilmore", "Billing", 34, 40);
		
		for (int i = 0; i < employees.length; i++)
		{
			System.out.println(employees[i] + "\n");
		}
		
		SortAge[] sortAgeEmployees = employees;
		
		for (int i = 0; i < sortAgeEmployees.length; i++)
		{
			System.out.println(((Employee)sortAgeEmployees[i]).getName() + " is " + sortAgeEmployees[i].getAge() + " years old");
		}
	}
}
