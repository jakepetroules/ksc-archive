package jpetroules.cs290;

/**
 * Contains static methods related to length units.
 * @author Jake Petroules
 */
public final class LengthUnits
{
	/**
	 * Gets the multiplier to convert meters to the unit specified by {@link unit}.
	 * @param unit The unit to get the meter multiplier for.
	 * @return The multiplier.
	 * @throws IllegalArgumentException An unsupported unit was specified.
	 */
	public static double getMultiplier(String unit) throws IllegalArgumentException
	{
		if (unit == "millimeters")
		{
			return 1000;
		}
		else if (unit == "centimeters")
		{
			return 100;
		}
		else if (unit == "meters")
		{
			return 1;
		}
		else if (unit == "kilometers")
		{
			return 0.001;
		}
		else if (unit == "inches")
		{
			return 39.3700787;
		}
		else if (unit == "feet")
		{
			return 3.2808399;
		}
		else if (unit == "yards")
		{
			return 1.0936133;
		}
		else if (unit == "miles")
		{
			return 0.000621371192;
		}
		else if (unit == "knots")
		{
			return 0.000539956803;
		}
		else
		{
			throw new IllegalArgumentException();
		}
	}
}
