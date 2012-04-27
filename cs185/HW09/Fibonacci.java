package HW09;

import java.io.*;

/**
 * Provides methods for calculating Fibonacci numbers.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename Fibonacci.java
 */
public class Fibonacci
{
	/**
	 * The maximum Fibonacci number to calculate.
	 */
	private int max;
	
	/**
	 * The stream to write data to.
	 */
	private PrintWriter target;

	/**
	 * Initializes a new instance of the {@link Fibonacci} class.
	 * @param max The maximum Fibonacci number to calculate.
	 * @param printWriter The stream to write data to, or <code>null</code>.
	 */
	public Fibonacci(int max, PrintWriter printWriter)
	{
		this.setMax(max);
		this.setTarget(printWriter);
	}
	
	/**
	 * Gets the maximum Fibonacci number to calculate.
	 * @return The maximum Fibonacci number to calculate.
	 */
	public int getMax()
	{
		return this.max;
	}

	/**
	 * Sets the maximum Fibonacci number to calculate.
	 * @param The maximum Fibonacci number to calculate.
	 */
	public void setMax(int max)
	{
		this.max = max;
	}
	
	/**
	 * Gets the stream to write data to.
	 * @return The stream to write data to.
	 */
	public PrintWriter getTarget()
	{
		return this.target;
	}

	/**
	 * Sets the stream to write data to.
	 * @param target The stream to write data to.
	 */
	public void setTarget(PrintWriter target)
	{
		this.target = target;
	}
	
	/**
	 * Displays and calculates the Fibonacci number up to the maximum set.
	 * @see getMax
	 * @see setMax
	 */
	public void process()
	{
		if (this.getTarget() != null)
		{
			this.getTarget().println("This file contains the Fibonacci sequence up to " + this.getMax());
			this.getTarget().println(1);
			this.getTarget().println(1);
		}
		
		this.process(1, 1);
	}
	
	/**
	 * Displays and calculates the Fibonacci number that is the sum of {@link x} and {@link y}.
	 * @param x The first Fibonacci number to start at.
	 * @param y The second Fibonacci number to start at.
	 */
	private void process(int x, int y)
	{
		int z = x + y;
		
		if (z > max)
		{
			return;
		}
		
		System.out.println(z);
		if (this.getTarget() != null)
		{
			this.getTarget().println(z);
		}
		
		this.process(y, z);
	}
}
