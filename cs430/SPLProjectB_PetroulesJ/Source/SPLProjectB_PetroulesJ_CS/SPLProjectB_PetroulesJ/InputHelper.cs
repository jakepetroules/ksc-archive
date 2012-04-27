using System;

public class InputHelper
{
    /// <summary>
    /// Prompts the user to enter an integer greater than or equal to 0.
    /// </summary>
    /// <param name="promptMessage">The prompt message displayed to the user for input.</param>
    /// <param name="errorMessage">The error message displayed if the user does not enter an integer.</param>
    /// <returns>The integer that the user entered.</returns>
    public static int getInteger(string promptMessage, string errorMessage)
    {
        int id = -1;
        do
        {
            Console.Write(promptMessage);

            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(errorMessage);
            }
        }
        while (id == -1);

        return id;
    }

    public static int getIntegerInRange(string promptMessage, int min, int max)
    {
        bool valid = false;
        int id = 0;
        do
        {
            Console.Write(promptMessage);

            try
            {
                id = Convert.ToInt32(Console.ReadLine());
                valid = id >= min && id <= max;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid integer between " + min + " and " + max + ", inclusive.");
            }
        }
        while (!valid);

        return id;
    }

    public static String getString(string promptMessage, string errorMessage = null)
    {
        string name = string.Empty;
        do
        {
            Console.Write(promptMessage);
            name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name) && errorMessage != null)
            {
                Console.WriteLine(errorMessage);
            }
        }
        while (string.IsNullOrWhiteSpace(name));

        return name;
    }

    public static bool getBoolean(string promptMessage)
    {
        return InputHelper.getBoolean(promptMessage, "true", "false");
    }

    public static bool getBoolean(string promptMessage, string yes, string no)
    {
        string openClose = string.Empty;
        do
        {
            Console.Write(promptMessage);
            Console.Write("(enter " + yes + " or " + no + ") ");
            openClose = Console.ReadLine();
        }
        while (!string.Equals(openClose, yes, StringComparison.OrdinalIgnoreCase) && !string.Equals(openClose, no, StringComparison.OrdinalIgnoreCase));

        return string.Equals(openClose, yes, StringComparison.OrdinalIgnoreCase);
    }

    public static DateTime getDate(string promptMessage)
    {
        DateTime date = DateTime.MinValue;
        do
        {
            Console.Write(promptMessage);
            Console.Write("(enter yyyy-MM-dd) ");

            try
            {
                date = parseDate(Console.ReadLine());
            }
            catch (FormatException e)
            {
            }
        }
        while (date == DateTime.MinValue);

        return date;
    }

    public static DateTime parseDate(string date)
    {
        try
        {
            return DateTime.Parse(date);
        }
        catch (FormatException e)
        {
            throw e;
        }
    }
}