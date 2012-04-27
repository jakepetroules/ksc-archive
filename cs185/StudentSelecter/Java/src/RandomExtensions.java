import java.awt.*;
import java.util.*;

/**
 * Provides extensions to the {@link Random} class.
 */
public final class RandomExtensions
{
	/**
	 * The internal random instance used to drive the RNG.
	 */
	private Random random;

	/**
	 * Initializes a new instance of the {@link RandomExtensions} class.
	 */
	public RandomExtensions()
	{
		this.random = new Random();
	}

	/**
	 * Generates a random boolean value.
	 */
	public boolean generateBoolean()
	{
		return this.random.nextDouble() > 0.5;
	}

	/**
	 * Generates a random Unicode character between code points
	 * {@link Character.MIN_VALUE} and {@link Character.MAX_VALUE}, inclusive.
	 */
	public char generateCharacter()
	{
		return this.generateCharacter((int)Character.MIN_VALUE, (int)Character.MAX_VALUE);
	}

	/**
	 * Generates a random Unicode character between code points {@link min} and {@link max}, inclusive.
	 * @param min The lowest Unicode code point that may be returned.
	 * @param max The highest Unicode code point that may be returned.
	 * @exception IllegalArgumentException {@link min} is greater than {@link max}.
	 */
	public char generateCharacter(int min, int max)
	{
		if (min > max)
		{
			throw new IllegalArgumentException("min is greater than max");
		}

		return (char)this.generateNumber(min, max);
	}

	/**
	 * Generates a random Unicode character between code points {@link Character.MIN_VALUE} and {@link Character.MAX_VALUE},
	 * inclusive, and returns the result as a string containing a single character.
	 */
	public String generateCharacterString()
	{
		return String.valueOf(this.generateCharacter());
	}

	/**
	 * Generates a random Unicode character between code points {@link Character.MIN_VALUE} and {@link Character.MAX_VALUE},
	 * inclusive, and returns the result as a string containing a single character.
	 * @param min The lowest Unicode code point that may be returned.
	 * @param max The highest Unicode code point that may be returned.
	 * @exception IllegalArgumentException {@link min} is greater than {@link max}.
	 */
	public String generateCharacterString(int min, int max)
	{
		return String.valueOf(this.generateCharacter(min, max));
	}

	/**
	 * Generates a random color. The alpha transparency value is always 255.
	 */
	public Color generateColor()
	{
		return new Color(random.nextInt(256), random.nextInt(256), random.nextInt(256));
	}

	/**
	 * Generates a random index in an array. The minimum value is 0 and the
	 * maximum value is the length of the array minus 1.
	 * @param arrayLength The length of the array or size of the collection to generate an index for.
	 * @exception IllegalArgumentException {@link arrayLength} is less than or equal to zero.
	 */
	public int generateIndex(int arrayLength)
	{
		if (arrayLength <= 0)
		{
			throw new IllegalArgumentException("The array is empty.");
		}

		return this.generateNumber(0, arrayLength - 1);
	}

	/**
	 * Generates a random color. The alpha transparency value will be varied.
	 */
	public Color generateTransparentColor()
	{
		return new Color(this.random.nextInt(256), this.random.nextInt(256), this.random.nextInt(256), this.random.nextInt(256));
	}

	/**
	 * Generates a random integer between {@link Integer.MIN_VALUE} and {@link Integer.MAX_VALUE}, inclusive.
	 */
	public int generateNumber()
	{
		return this.generateNumber(Integer.MIN_VALUE, Integer.MAX_VALUE);
	}

	/**
	 * Generates a random number between {@link min} and {@link max}, inclusive.
	 * @param min The minimum number that may be returned.
	 * @param max The maximum number that may be returned.
	 * @exception IllegalArgumentException {@link min} is greater than {@link max}.
	 */
	public int generateNumber(int min, int max)
	{
		if (min > max)
		{
			throw new IllegalArgumentException("min is greater than max");
		}

		if (min == Integer.MAX_VALUE && max == Integer.MAX_VALUE)
		{
			// If min and max are both Integer.MAX_VALUE, return that
			return Integer.MAX_VALUE;
		}
		else if (min > Integer.MIN_VALUE && max == Integer.MAX_VALUE)
		{
			// If min is greater than Integer.MIN_VALUE AND max is
			// Integer.MAX_VALUE, trick it
			return this.nextInt(min - 1, max) + 1;
		}
		else if (min == Integer.MIN_VALUE && max == Integer.MAX_VALUE)
		{
			// This gets a bit more difficult if we want the full range,
			// so simply offset one range by one, and then pick one
			int range1 = this.nextInt(min, max) + 1;
			int range2 = this.nextInt(min, max);

			// Decide which range to pick
			if (this.generateBoolean())
			{
				return range1;
			}
			else
			{
				return range2;
			}
		}

		return this.nextInt(min, max + 1);
	}

	/**
	 * Generates a random point whose X and Y coordinates are each in the range
	 * {@link Integer.MIN_VALUE} and {@link Integer.MAX_VALUE}, inclusive.
	 */
	public Point generatePoint()
	{
		return this.generatePoint(Integer.MIN_VALUE, Integer.MAX_VALUE);
	}

	/**
	 * Generates a random point whose X and Y coordinates are each in the range {@link min} and {@link max}, inclusive.
	 * @param min The minimum value for the X or Y coordinate.
	 * @param max The maximum value for the X or Y coordinate.
	 * @exception IllegalArgumentException {@link min} is greater than {@link max}.
	 */
	public Point generatePoint(int min, int max)
	{
		if (min > max)
		{
			throw new IllegalArgumentException("min is greater than max");
		}

		return this.generatePoint(min, max, min, max);
	}

	/**
	 * Generates a random point whose X and Y coordinates are each in the range
	 * {@link Integer.MIN_VALUE} and {@link Integer.MAX_VALUE}, inclusive.
	 * @param min The minimum values for the X and Y coordinates.
	 * @param max The maximum values for the X and Y coordinates.
	 * @exception IllegalArgumentException The X coordinate of one component is greater than its corresponding Y component.
	 */
	public Point generatePoint(Point min, Point max)
	{
		if (min.x > max.x || min.y > max.y)
		{
			throw new IllegalArgumentException("The X coordinate of one component is greater than its corresponding Y component.");
		}

		return this.generatePoint(min.x, max.x, min.y, max.y);
	}

	/**
	 * Generates a random point whose X and Y coordinates are each in the range
	 * {@link Integer.MIN_VALUE} and {@link Integer.MAX_VALUE}, inclusive.
	 * @param minX The minimum value for the X coordinate.
	 * @param maxX The maximum value for the X coordinate.
	 * @param minY The minimum value for the Y coordinate.
	 * @param maxY The maximum value for the Y coordinate.
	 * @exception IllegalArgumentException The X coordinate of one component is greater than its corresponding Y component.
	 */
	public Point generatePoint(int minX, int maxX, int minY, int maxY)
	{
		if (minX > maxX || minY > maxY)
		{
			throw new IllegalArgumentException("The X coordinate of one component is greater than its corresponding Y component.");
		}

		return new Point(this.generateNumber(minX, maxX), this.generateNumber(minY, maxY));
	}
	
	/**
	 * Returns a pseudorandom integer between {@link min} (inclusive) and {@link max} (exclusive).
	 * @param min The inclusive lower bound of the value to be returned.
	 * @param max The exclusive upper bound of the value to be returned.
	 */
	private int nextInt(int min, int max)
	{
		return this.random.nextInt(max - min) + min;
	}
}
