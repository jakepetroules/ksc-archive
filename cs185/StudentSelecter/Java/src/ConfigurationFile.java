import java.io.*;

/**
 * Provides an interface to the program's configuration file.
 */
public final class ConfigurationFile
{
	/**
	 * The FTP host server on which to store data.
	 */
	private static String host;
	
	/**
	 * The FTP path at which the student data is stored.
	 */
	private static String path;
	
	/**
	 * The username used to login to the FTP server.
	 */
	private static String username;
	
	/**
	 * The password used to login to the FTP server.
	 */
	private static String password;
	
	/**
	 * Loads the configuration file into memory.
	 * @throws IOException An I/O error occurs.
	 */
	public static void load() throws IOException
	{
		File serverSettings = new File("res/DefaultSettings.ini");
		if (serverSettings.exists())
		{
			BufferedReader reader = new BufferedReader(new InputStreamReader(new FileInputStream(serverSettings.getAbsolutePath())));
			ConfigurationFile.host = reader.readLine();
			ConfigurationFile.path = reader.readLine();
			ConfigurationFile.username = reader.readLine();
			ConfigurationFile.password = reader.readLine();
		}
	}

	/**
	 * Gets the FTP host server on which to store data.
	 * @return The FTP host server on which to store data.
	 */
	public static String getHost()
	{
		return ConfigurationFile.host;
	}

	/**
	 * Gets the FTP path at which the student data is stored.
	 * @return The FTP path at which the student data is stored.
	 */
	public static String getPath()
	{
		return ConfigurationFile.path;
	}

	/**
	 * Gets the username used to login to the FTP server.
	 * @return The username used to login to the FTP server.
	 */
	public static String getUsername()
	{
		return ConfigurationFile.username;
	}

	/**
	 * Gets the password used to login to the FTP server.
	 * @return The password used to login to the FTP server.
	 */
	public static String getPassword()
	{
		return ConfigurationFile.password;
	}
}
