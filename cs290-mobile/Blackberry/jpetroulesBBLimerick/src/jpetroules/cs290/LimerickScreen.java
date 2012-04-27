package jpetroules.cs290;

import net.rim.device.api.ui.component.*;
import net.rim.device.api.ui.container.*;

/**
 * Represents the Limerick main screen.
 * @author Jake Petroules
 */
public final class LimerickScreen extends MainScreen
{
	/**
	 * Initializes a new instance of the {@link LimerickScreen} class.
	 */
	public LimerickScreen()
	{
		super();
		
		this.add(new LabelField(
				"The limerick packs laughs anatomical\n" +
				"In space that is quite economical,\n" +
				"But the good ones I've seen\n" +
				"So seldom are clean,\n" +
				"And the clean ones so seldom are comical."));
	}
}
