package jpetroules.cs290;

import net.rim.device.api.ui.*;

/**
 * The main class for the Limerick application.
 * @author Jake Petroules
 */
public final class Limerick extends UiApplication
{
	/**
	 * Initializes a new instance of the {@link Limerick} class.
	 */
	public Limerick()
	{
		this.pushScreen(new LimerickScreen());
	}
	
	/**
	 * The entry point for the application.
	 * @param args Command-line arguments.
	 */
	public static void main(String[] args)
	{
		Limerick limerick = new Limerick();
		limerick.enterEventDispatcher();
	}
}
