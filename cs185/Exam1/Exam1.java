/**
 * Demonstrates an ice cream truck and ice cream flavors.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename Exam1.java
 */
public class Exam1
{
	public static void main(String[] args)
	{
		IceCream truck1 = new IceCream();
		
		truck1.makeSet();
		System.out.println(truck1.printSet());
	}
}
