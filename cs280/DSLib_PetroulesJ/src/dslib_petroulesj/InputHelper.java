package dslib_petroulesj;

import java.io.BufferedReader;
import java.io.IOException;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;

/**
 *
 * @author jakepetroules
 */
public class InputHelper
{
    /**
     * Prompts the user to enter an integer greater than or equal to 0.
     * @param reader The input stream to read from.
     * @param promptMessage The prompt message displayed to the user for input.
     * @param errorMessage The error message displayed if the user does not enter an integer.
     * @return The integer that the user entered.
     */
    public static int getInteger(BufferedReader reader, String promptMessage, String errorMessage) throws IOException
    {
        int id = -1;
        do
        {
            System.out.print(promptMessage);
            
            try
            {
                id = Integer.parseInt(reader.readLine());
            }
            catch (NumberFormatException ex)
            {
                System.out.println(errorMessage);
            }
        }
        while (id == -1);

        return id;
    }

    public static int getIntegerInRange(BufferedReader reader, String promptMessage, int min, int max) throws IOException
    {
        boolean valid = false;
        int id = 0;
        do
        {
            System.out.print(promptMessage);

            try
            {
                id = Integer.parseInt(reader.readLine());
                valid = id >= min && id <= max;
            }
            catch (NumberFormatException ex)
            {
                System.out.println("Please enter a valid integer between " + min + " and " + max + ", inclusive.");
            }
        }
        while (!valid);

        return id;
    }

    public static String getString(BufferedReader reader, String promptMessage) throws IOException
    {
        return getString(reader, promptMessage, null);
    }

    public static String getString(BufferedReader reader, String promptMessage, String errorMessage) throws IOException
    {
        String name = "";
        do
        {
            System.out.print(promptMessage);
            name = reader.readLine();
            if (name.equals("") && errorMessage != null)
            {
                System.out.println(errorMessage);
            }
        }
        while (name.equals(""));

        return name;
    }
    
    public static boolean getBoolean(BufferedReader reader, String promptMessage) throws IOException
    {
        return InputHelper.getBoolean(reader, promptMessage, "true", "false");
    }

    public static boolean getBoolean(BufferedReader reader, String promptMessage, String yes, String no) throws IOException
    {
        String openClose = "";
        do
        {
            System.out.print(promptMessage);
            System.out.print("(enter " + yes + " or " + no + ") ");
            openClose = reader.readLine();
        }
        while (!openClose.equalsIgnoreCase(yes) && !openClose.equalsIgnoreCase(no));

        return openClose.equalsIgnoreCase(yes);
    }

    public static Date getDate(BufferedReader reader, String promptMessage) throws IOException
    {
        Date date = null;
        do
        {
            System.out.print(promptMessage);
            System.out.print("(enter yyyy-MM-dd) ");

            try
            {
                date = parseDate(reader.readLine());
            }
            catch (ParseException e)
            {
            }
        }
        while (date == null);

        return date;
    }

    public static Date parseDate(String date) throws ParseException
    {
        DateFormat df = new SimpleDateFormat("yyyy-MM-dd");

        try
        {
            return df.parse(date);
        }
        catch (ParseException e)
        {
            throw e;
        }
    }
}
