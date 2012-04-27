package OperatingSystemCollection;

import java.io.*;

/**
 * Represents an operating system.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename OperatingSystem.java
 */
public final class OperatingSystem implements Comparable<OperatingSystem>
{
	/**
	 * The manufacturer of the operating system.
	 */
	private String manufacturer;
	
	/**
	 * The brand name of the operating system.
	 */
	private String name;
	
	/**
	 * The version of the operating system.
	 */
	private String version;
	
	/**
	 * The version name of the operating system (e.g. Vista or Leopard).
	 */
	private String versionName;
	
	/**
	 * Initializes a new instance of the {@link OperatingSystem} class with no data.
	 */
	public OperatingSystem()
	{
	}
	
	/**
	 * Initializes a new instance of the {@link OperatingSystem} class.
	 * @param manufacturer The manufacturer of the operating system.
	 * @param name The brand name of the operating system.
	 * @param version The version of the operating system.
	 * @param versionName The version name of the operating system (e.g. Vista or Leopard).
	 */
	public OperatingSystem(String manufacturer, String name, String version, String versionName)
	{
		this.manufacturer = manufacturer;
		this.name = name;
		this.version = version;
		this.versionName = versionName;
	}

	/**
	 * Gets the brand name of the operating system.
	 * @return The brand name of the operating system.
	 */
	public String getName()
	{
		return this.name;
	}

	/**
	 * Sets the brand name of the operating system.
	 * @param name The brand name of the operating system.
	 */
	public void setName(String name)
	{
		this.name = name;
	}

	/**
	 * Gets the manufacturer of the operating system.
	 * @return The manufacturer of the operating system.
	 */
	public String getManufacturer()
	{
		return this.manufacturer;
	}

	/**
	 * Sets the manufacturer of the operating system.
	 * @param The manufacturer of the operating system.
	 */
	public void setManufacturer(String manufacturer)
	{
		this.manufacturer = manufacturer;
	}

	/**
	 * Gets the version of the operating system.
	 * @return The version of the operating system.
	 */
	public String getVersion()
	{
		return this.version;
	}

	/**
	 * Sets the version of the operating system.
	 * @param The version of the operating system.
	 */
	public void setVersion(String version)
	{
		this.version = version;
	}

	/**
	 * Gets the version name of the operating system (e.g. Vista or Leopard).
	 * @return The version name of the operating system (e.g. Vista or Leopard).
	 */
	public String getVersionName()
	{
		return this.versionName;
	}

	/**
	 * Sets the version name of the operating system (e.g. Vista or Leopard).
	 * @param versionName The version name of the operating system (e.g. Vista or Leopard).
	 */
	public void setVersionName(String versionName)
	{
		this.versionName = versionName;
	}
	
	/**
	 * Reads an {@link OperatingSystem} from a {@link DataInputStream}.
	 * @param stream The stream to read from.
	 * @return The read {@link OperatingSystem}.
	 * @throws IOException An I/O error occurred reading the data.
	 */
	public static OperatingSystem readFromStream(DataInputStream stream) throws IOException
	{
		OperatingSystem system = new OperatingSystem();
		system.setManufacturer(stream.readUTF());
		system.setName(stream.readUTF());
		system.setVersion(stream.readUTF());
		system.setVersionName(stream.readUTF());
		return system;
	}
	
	/**
	 * Writes this object to a {@link DataOutputStream}.
	 * @param stream The stream to write to.
	 * @throws IOException An I/O error occurred writing the data.
	 */
	public void writeToStream(DataOutputStream stream) throws IOException
	{
		stream.writeUTF(this.getManufacturer());
		stream.writeUTF(this.getName());
		stream.writeUTF(this.getVersion());
		stream.writeUTF(this.getVersionName());
	}
	
	/**
	 * Compares two operating systems by their version names for ordering.
	 * @param o The {@link OperatingSystem} to compare to.
	 */
	@Override
	public int compareTo(OperatingSystem o)
	{
		return this.getVersionName().compareTo(o.getVersionName());
	}
	
	/**
	 * Gets a string representing the {@link OperatingSystem}.
	 */
	@Override
	public String toString()
	{
		return this.manufacturer + " " + this.name + " " + this.versionName;
	}
}
