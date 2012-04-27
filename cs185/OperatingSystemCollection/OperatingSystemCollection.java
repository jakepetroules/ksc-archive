package OperatingSystemCollection;

import CollectionImplementation.*;

/**
 * Represents a collection of operating systems.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename OperatingSystemCollection.java
 */
public final class OperatingSystemCollection extends CollectionBase<OperatingSystem>
{
	/**
	 * Initializes a new instance of the {@link OperatingSystemCollection} class with the default capacity.
	 */
	public OperatingSystemCollection()
	{
		super();
	}
	
	/**
	 * Initializes a new instance of the {@link OperatingSystemCollection} class with the default capacity and members.
	 * @param array The array of operating systems to insert into the collection initially.
	 */
	public OperatingSystemCollection(OperatingSystem[] array)
	{
		super(array);
	}
	
	/**
	 * Initializes a new instance of the {@link OperatingSystemCollection} class.
	 * @param capacity The default size of the internal array.
	 */
	public OperatingSystemCollection(int capacity)
	{
		super(capacity);
	}
	
	/**
	 * Adds an {@link OperatingSystem} to the collection.
	 * @param manufacturer The manufacturer of the operating system.
	 * @param name The brand name of the operating system.
	 * @param version The version of the operating system.
	 * @param versionName The version name of the operating system (e.g. Vista or Leopard).
	 */
	public void add(String manufacturer, String name, String version, String versionName)
	{
		this.add(new OperatingSystem(manufacturer, name, version, versionName));
	}
	
	/**
	 * Gets a string representing the {@link OperatingSystemCollection}.
	 * @return A string representing the {@link OperatingSystemCollection}.
	 */
	@Override
	public String toString()
	{
		// Create a new grid formatter with the specified header
		GridFormatter formatter = new GridFormatter("Manufacturer", "Name", "Version");
		
		formatter.setNullDisplayText("-");
		
		for (int i = 0; i < this.size(); i++)
		{
			formatter.addRow(this.get(i).getManufacturer(), this.get(i).getName(), this.get(i).getVersionName());
		}
		
		return formatter.toString();
	}
}
