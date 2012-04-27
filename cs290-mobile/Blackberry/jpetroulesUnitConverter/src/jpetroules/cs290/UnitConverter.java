package jpetroules.cs290;

import net.rim.device.api.ui.*;

/**
 * The main class for the Unit Converter application.
 * @author Jake Petroules
 */
public final class UnitConverter extends UiApplication
{
	/**
	 * The entry point for the application.
	 * @param args Command-line arguments.
	 */
	public static void main(String[] args)
	{
		UnitConverter screen = new UnitConverter();
		screen.enterEventDispatcher();
	}
	
	/**
	 * Initializes a new instance of the {@link UnitConverter} class.
	 */
	public UnitConverter()
	{
		this.pushScreen(new UnitConverterScreen());
	}
}
