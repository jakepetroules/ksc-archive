package jpetroules.cs290;

import net.rim.device.api.ui.*;
import net.rim.device.api.ui.component.*;
import net.rim.device.api.ui.container.*;

/**
 * Represents the Unit Converter main screen.
 * @author Jake Petroules
 */
public final class UnitConverterScreen extends MainScreen
{
	/**
	 * The source unit combo box.
	 */
	private ObjectChoiceField sourceUnit;
	
	/**
	 * The destination unit combo box.
	 */
	private ObjectChoiceField destUnit;
	
	/**
	 * The input text box.
	 */
	private EditField input;
	
	/**
	 * The calculate button.
	 */
	private ButtonField calculate;
	
	/**
	 * The reset button.
	 */
	private ButtonField reset;
	
	/**
	 * The output label.
	 */
	private LabelField outputLabel;
	
	/**
	 * Initializes a new instance of the {@link UnitConverterScreen} class.
	 */
	public UnitConverterScreen()
	{
		super();
		
		// Create the source and destination unit combo boxes
		this.sourceUnit = new ObjectChoiceField("Source unit", UnitConverterScreen.getUnits());
		this.destUnit = new ObjectChoiceField("Destination unit", UnitConverterScreen.getUnits());
		
		// Create the input box
		this.input = new EditField("Input", "");
		
		// Create the calculate and reset buttons
		this.calculate = new ButtonField("Calculate");
		this.reset = new ButtonField("Reset");
		
		// Create the label for the output
		this.outputLabel = new LabelField();
		
		// Add the controls to the GUI
		this.add(this.sourceUnit);
		this.add(this.destUnit);
		this.add(this.input);
		this.add(this.calculate);
		this.add(this.reset);
		this.add(this.outputLabel);
		
		// Add a click handler for the calculate button
		this.calculate.setChangeListener(new FieldChangeListener()
		{
			public void fieldChanged(Field field, int context)
			{
				UnitConverterScreen.this.calculate();
			}
		});
		
		// Add a click handler for the reset button
		this.reset.setChangeListener(new FieldChangeListener()
		{
			public void fieldChanged(Field field, int context)
			{
				UnitConverterScreen.this.reset();
			}
		});
	}
	
	/**
	 * Calculates the result of the unit conversion.
	 */
	public void calculate()
	{
		String sourceUnitType = (String)this.sourceUnit.getChoice(this.sourceUnit.getSelectedIndex());
		String destUnitType = (String)this.destUnit.getChoice(this.destUnit.getSelectedIndex());
		
		double sourceUnitMultiplier = LengthUnits.getMultiplier(sourceUnitType);
		double destUnitMultiplier = LengthUnits.getMultiplier(destUnitType);
		
		double units = Integer.parseInt(this.input.getText());
		
		this.outputLabel.setText(String.valueOf((units * (1 / sourceUnitMultiplier)) * destUnitMultiplier));
	}
	
	/**
	 * Resets the GUI, setting all controls back to their defaults.
	 */
	public void reset()
	{
		this.sourceUnit.setSelectedIndex(0);
		this.destUnit.setSelectedIndex(0);
		this.input.setText("");
		this.outputLabel.setText("");
	}
	
	/**
	 * Gets the units that can be converted.
	 * @return An array of strings representing the available units that can be converted.
	 */
	public static Object[] getUnits()
	{
		return new Object[]
		{
			// SI units
			"millimeters",
			"centimeters",
			"meters",
			"kilometers",
			
			// English units
			"inches",
			"feet",
			"yards",
			"miles",
			"knots"
		};
	}
}
