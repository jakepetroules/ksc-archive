package HW08;

/**
 * Jake Petroules CS140-04 Filename: HW08.java
 * This program demonstrates the use of object oriented programming with light bulb objects that can be turned on or off.
 */

public class HW08
{
	public static void main(String[] args)
	{
		// Explain to the user what the program does
		System.out.println("This program demonstrates the use of object oriented programming with light bulb objects that can be turned on or off.");
		
		// Instantiate two Bulb objects
		Bulb bulb1 = new Bulb();
		Bulb bulb2 = new Bulb();
		
		// Set the first bulb to 'on'
		bulb1.setState(true);
		
		// Print the state of each bulb
		printBulbState("Bulb1", bulb1);
		printBulbState("Bulb2", bulb2);
		
		// Turn the first bulb off, and the second bulb on
		bulb1.setState(false);
		bulb2.setState(true);
		
		// Print the state of each bulb again
		printBulbState("Bulb1", bulb1);
		printBulbState("Bulb2", bulb2);
	}
	
	// Prints the state of a light bulb (whether it is on or off)
	// as text. The first parameter is the name of the bulb, and
	// the second is the bulb object
	public static void printBulbState(String bulbName, Bulb bulb)
	{
		System.out.println(bulbName + ": This lightbulb is currently " + bulb.getStateText());
	}
}
