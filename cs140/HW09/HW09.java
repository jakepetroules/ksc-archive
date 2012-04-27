package HW09;

/**
 * Jake Petroules CS140-04 Filename: HW09.java
 * This program demonstrates the use of object oriented programming with sphere
 * objects whose diameter can be changed and the volume and surface area calculated.
 */

import java.text.NumberFormat;

public class HW09
{
	public static void main(String[] args)
	{
		// Explain to the user what the program does
		System.out.println("This program demonstrates the use of object oriented programming with sphere objects " +
				"whose diameter can be changed and the volume and surface area calculated.");
		
		// Instantiate a number formatter and set the formatter so it displays 4 digits
		NumberFormat format = NumberFormat.getNumberInstance();
		format.setMaximumFractionDigits(4);
		
		// Instantiate two sphere objects
		Sphere sphere1 = new Sphere(1);
		Sphere sphere2 = new Sphere(3);
		
		// Print the spheres' information
		System.out.println("Sphere 1: " + sphere1);
		System.out.println("Sphere 2: " + sphere2);
		
		// Change the spheres' diameter
		sphere1.setDiameter(5);
		sphere2.setDiameter(10);
		
		// Print the diameter of sphere 2
		System.out.println("The diameter of Sphere #2 is " + format.format(sphere2.getDiameter()));
		
		// Print the spheres' information again
		System.out.println("Sphere 1: " + sphere1);
		System.out.println("Sphere 2: " + sphere2);
	}
}
