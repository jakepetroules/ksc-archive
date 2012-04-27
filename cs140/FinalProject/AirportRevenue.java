package AirportRevenue;

import java.io.File;
import java.io.FileNotFoundException;
import java.text.NumberFormat;
import java.util.Scanner;

/**
 * This program prints ticket details and calculates the daily revenue for an airline.
 * @author Jason Bothwick, Jake Petroules, Hector Sanchez
 */
public class AirportRevenue
{
	public static void main(String[] args) throws FileNotFoundException
	{
		// Print a welcome message
		System.out.println("This program prints ticket details and calculates the daily revenue for an airline.");
		System.out.println();
		
		// Print the headers
		System.out.print("Origin\t");
		System.out.print("Destination\t");
		System.out.print("Time\t");
		System.out.print("Base Price\t");
		System.out.print("Luggage\t");
		System.out.print("Final Price\t");
		System.out.println();
		System.out.println("===================================================================");
		
		// Read our data from the file
		Scanner scan = new Scanner(new File("data.txt"));
		
		// Track the total income earned from the day's ticket
		double totalTicketIncome = 0;
		
		// Keep going until the file has no more data
		while (scan.hasNext())
		{
			// Create a new ticket and set all the properties to the data from the file
			Ticket ticket = new Ticket();
			ticket.setDestination(scan.next());
			ticket.setDepartureTime(scan.nextInt());
			ticket.setBaseTicketPrice(scan.nextDouble());
			ticket.setLuggageCount(scan.nextInt());
			
			// Add this ticket's final price to the total income
			totalTicketIncome += ticket.calculateFinalTicketPrice();
			
			// Print the ticket
			System.out.println(ticket);
		}
		
		// Instantiate a currency formatter and print today's ticket income
		NumberFormat currency = NumberFormat.getCurrencyInstance();
		System.out.println();
		System.out.println("Today's ticket income: " + currency.format(totalTicketIncome));
	}
}
