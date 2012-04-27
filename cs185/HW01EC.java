package HW01EC;

import java.io.*;
import java.text.*;
import java.util.*;

/**
 * This program will print a month calendar for the month of the user's birth.
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename HW01EC.java
 */
public class HW01EC
{
	public static void main(String[] args) throws IOException
	{
		// Create a buffered reader to get input from the user
		BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

		// Print a message explaining what the program does
		System.out.println("This program will print a month calendar for the month of your birth.");

		// Prompt for and obtain the user's name
		String name = null;
		while (name == null || name.length() == 0)
		{
			System.out.print("Please enter your name: ");
			name = reader.readLine();
		}

		// Prompt for and obtain the user's birth date
		Calendar birthDate = null;
		DateFormat format = new SimpleDateFormat("yyyy-MM-dd");
		while (birthDate == null)
		{
			System.out.print("Please enter your birth date in the format yyyy-mm-dd (ISO 8601): ");
			try
			{
				Date date = format.parse(reader.readLine());

				birthDate = Calendar.getInstance();
				birthDate.setTime(date);
			}
			catch (ParseException e)
			{
				System.out.println(e.getMessage());
			}
		}

		// Print a message and a month calendar for the month of the user's birth
		System.out.printf("The birthday month for %s for the year %d is:\n", name, birthDate.get(Calendar.YEAR));
		printMonthCalendar(birthDate);
		System.out.printf("%s's current age is %d", name, calculateAge(birthDate));
	}

	/**
	 * Prints a month calendar for the date specified by {@link calendar}.
	 * @param calendar The calendar to get the date to print, from.
	 */
	private static void printMonthCalendar(Calendar calendar)
	{
		// This the the month header, showing the letters for each of the days
		String monthHeader = "  S    M    T    W    T    F    S";
		String monthYear = calendar.getDisplayName(Calendar.MONTH, Calendar.LONG, Locale.getDefault());

		// Print a number of spaces equal to half the width of the month header,
		// so that the "MONTH YEAR" display will be centered
		int spaces = (monthHeader.length() - monthYear.length()) / 2;
		for (int i = 0; i < spaces; i++)
		{
			System.out.print(" ");
		}

		// Print the headers
		System.out.println(monthYear);
		System.out.println(monthHeader);

		// Clone the calendar we were given and set its day to
		// the first of the month so we know what day to start
		// the calendar
		Calendar temp = (Calendar)calendar.clone();
		temp.set(Calendar.DAY_OF_MONTH, 1);

		// Get the day of the week the first of the month is on,
		// and the number of days in that month
		int dayOfWeek = temp.get(Calendar.DAY_OF_WEEK);
		int daysInMonth = daysInMonth(temp.get(Calendar.MONTH), isLeapYear(temp.get(Calendar.YEAR)));

		// Print 3 blank spaces for each day the month does not
		// start on - e.g. this will print 9 spaces if the month
		// starts on Wednesday
		for (int i = 1; i < dayOfWeek; i++)
		{
			System.out.print("     ");
		}

		// Print each day of the month...
		for (int i = 0; i < daysInMonth; i++)
		{
			// Print the day of the month as a number
			// The %2d makes adds a space in front of
			// the number if it is only one digit long,
			// so everything will line up nicely
			System.out.printf(" %2d", i + 1);

			// If this is the day specified by the input,
			// print a star next to that day to highlight it
			if (calendar.get(Calendar.DAY_OF_MONTH) == i + 1)
			{
				System.out.print("* ");
			}
			else
			{
				System.out.print("  ");
			}

			// If we've printed Saturday or we just printed the last
			// day of a month, go to the next line
			if ((i + dayOfWeek) % 7 == 0 || i == (daysInMonth - 1))
			{
				System.out.println();
			}
		}
	}

	/**
	 * Calculates a person's age using their birth date and the current date and time.
	 * @param birthDate The person's birth date.
	 * @return The person's age.
	 */
	private static int calculateAge(Calendar birthDate)
	{
		// Get today's date and time
		Calendar currentDate = Calendar.getInstance();

		// Get the person's final age for the end of this year
		int endYearAge = currentDate.get(Calendar.YEAR) - birthDate.get(Calendar.YEAR);

		// Clone the birth date calendar and add the person's end year age to it
		// This results in the person's birth date for this year
		Calendar currentYearBirthDate = (Calendar)birthDate.clone();
		currentYearBirthDate.add(Calendar.YEAR, endYearAge);

		// If the current date and time is before the person's birthday this
		// year, subtract one from their calculated age
		if (currentDate.before(currentYearBirthDate))
		{
			endYearAge--;
		}

		return endYearAge;
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
		switch (month)
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
