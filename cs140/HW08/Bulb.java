package HW08;

// This class represents a bulb object that can be turned on or off
public class Bulb
{
	// Stores whether the bulb is on or off. True means on and false means off.
	private boolean isBulbOn;
	
	// Constructor for the bulb class
	public Bulb()
	{
		// Initially sets the bulb state to false/off
		isBulbOn = false;
	}
	
	// Gets the state of the bulb - again, true means on and false means off.
	public boolean getState()
	{
		return isBulbOn;
	}
	
	// Sets the state of the bulb - again, true means on and false means off.
	public void setState(boolean on)
	{
		isBulbOn = on;
	}
	
	// Gets the state of the bulb as a String - this method will return "on" if the
	// bulb state is true, and "off" is the bulb state is false.
	public String getStateText()
	{
		// If the state of the bulb is "true", then the bulb is on
		if (getState() == true)
		{
			return "on";
		}
		else
		{
			return "off";
		}
	}
}
