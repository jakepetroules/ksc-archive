package HW09;

import java.text.NumberFormat;

public class Sphere
{
	private double diameter;
	
	// Instantiate a number formatter
	private NumberFormat format = NumberFormat.getNumberInstance();
	
	// Instantiate new Spheres
	public Sphere(double diameter)
	{
		this.setDiameter(diameter);
		
		// Set the formatter so it displays 4 digits
		this.format.setMaximumFractionDigits(4);
	}
	
	// Gets the sphere's diameter
	public double getDiameter()
	{
		return this.diameter;
	}
	
	// Sets the sphere's diameter
	public void setDiameter(double diameter)
	{
		this.diameter = diameter;
	}
	
	// Gets the sphere's volume
	public double getVolume()
	{
		return (4.0 / 3.0) * Math.PI * Math.pow(this.getDiameter() / 2, 3);
	}
	
	// Gets the sphere's surface area
	public double getSurfaceArea()
	{
		return 4 * Math.PI * Math.pow(this.getDiameter() / 2, 2);
	}
	
	// Gets a string representation of the sphere
	public String toString()
	{
		return "This sphere has a diameter of " + this.getDiameter() +
			", a volume of " + format.format(this.getVolume()) +
			" and a surface area of " + format.format(this.getSurfaceArea()); 
	}
}
