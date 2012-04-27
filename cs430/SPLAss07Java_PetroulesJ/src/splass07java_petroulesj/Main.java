package splass07java_petroulesj;

import java.io.*;
import java.util.*;

public class Main
{
    public static void main(String[] args) throws IOException
    {
        System.out.println("Enter a date:");
        try
        {
            System.out.println("The date you entered was: " + enterDate());
        }
        catch (IllegalArgumentException e)
        {
            System.out.println(e.getMessage());
        }
    }

    static String enterDate() throws IOException
    {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        System.out.print("Enter the year: ");
        int year = Integer.MIN_VALUE;
        do
        {
            try
            {
                year = Integer.valueOf(reader.readLine());
            }
            catch (NumberFormatException nf)
            {
                System.out.print("Invalid year! Try again: ");
            }
        }
        while (year == Integer.MIN_VALUE);

        System.out.print("Enter the month: ");
        int month = 0;
        do
        {
            try
            {
                month = Integer.valueOf(reader.readLine());
            }
            catch (NumberFormatException nf)
            {
                System.out.print("Invalid month! Try again: ");
            }
        }
        while (month < 1 || month > 12);

        System.out.print("Enter the day: ");
        int day = 0;
        do
        {
            try
            {
                day = Integer.valueOf(reader.readLine());
            }
            catch (NumberFormatException nf)
            {
                System.out.print("Invalid day! Try again: ");
            }
        }
        while (day < 1 || day > daysInMonth(month, isLeapYear(year)));

        if (year == 1582 && month == 10 && (day > 4 || day < 15))
        {
            throw new IllegalArgumentException("Dates between October 4th, 1582, and October 15th, 1582, " +
                    "are not valid in the Gregorian calendar. October 4th is followed immediately October 15th");
        }
        else if (year == 0)
        {
            throw new IllegalArgumentException("There is no year 0 in the Gregorian calendar - 1 BC is immediately followed by 1 AD");
        }

        return year + "-" + month + "-" + day;
    }

    /**
     * Gets a value indicating whether the specified year is a leap year.
     * @param year The year to check.
     * @return Whether the year is a leap year.
     */
    private static boolean isLeapYear(int year)
    {
        return ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
    }

    /**
     * Gets the number of days in the specified month.
     * @param month The number of the month to get the number of days in. 1 for January, 12 for December.
     * @param leapYear Whether the month specified month is in a leap year. This only affects the return
     * value if {@link month} is 2 (February).
     * @return The number of days in the specified month.
     * @throws IllegalArgumentException {@link month} is outside the range 1 to 12, inclusive.
     */
    private static int daysInMonth(int month, boolean leapYear) throws IllegalArgumentException
    {
        switch (month - 1)
        {
            // 30 days hath September, April, June, and November.
            case Calendar.SEPTEMBER:
            case Calendar.APRIL:
            case Calendar.JUNE:
            case Calendar.NOVEMBER:
                    return 30;

            // All the rest have 31,
            case Calendar.JANUARY:
            case Calendar.MARCH:
            case Calendar.MAY:
            case Calendar.JULY:
            case Calendar.AUGUST:
            case Calendar.OCTOBER:
            case Calendar.DECEMBER:
                    return 31;

            // except February which has 28, and 29 on leap years
            case Calendar.FEBRUARY:
                    return 28 + (leapYear ? 1 : 0);

            default:
                    throw new IllegalArgumentException("month must be between 1 and 12.");
        }
    }
}
