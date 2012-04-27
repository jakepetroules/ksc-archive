package AirportRevenue;

import java.text.NumberFormat;

/**
 * Represents an airline ticket.
 * @author Jason Bothwick, Jake Petroules, Hector Sanchez
 */
public class Ticket
{
	/**
	 * The three-letter IATA code of this origin airport.
	 */
	public static final String ORIGIN = "BOS";
	
	/**
	 * The three-letter IATA code of the destination airport.
	 */
	private String destination;
	
	/**
	 * The flight departure time in 24-hour time.
	 */
	private int departureTime;
	
	/**
	 * The base price for tickets to the destination airport from BOS.
	 */
	private double baseTicketPrice;
	
	/**
	 * The number of luggage pieces the passenger is taking.
	 */
	private int luggageCount;
	
	/**
	 * Initializes a new instance of the {@link Ticket} class.
	 */
	public Ticket()
	{
	}
	
	/**
	 * Gets the three-letter IATA code of the destination airport.
	 */
	public String getDestination()
	{
		return this.destination;
	}
	
	/**
	 * Sets the three-letter IATA code of the destination airport.
	 * @param destination The three-letter IATA code.
	 */
	public void setDestination(String destination)
	{
		this.destination = destination;
	}
	
	/**
	 * Gets the flight departure time in 24-hour time.
	 */
	public int getDepartureTime()
	{
		return this.departureTime;
	}
	
	/**
	 * Sets the flight departure time in 24-hour time.
	 * @param departureTime The departure time, example "800" or "1700".
	 */
	public void setDepartureTime(int departureTime)
	{
		this.departureTime = departureTime;
	}
	
	/**
	 * Gets the base price for tickets to the destination airport from BOS.
	 */
	public double getBaseTicketPrice()
	{
		return this.baseTicketPrice;
	}
	
	/**
	 * Sets the base price for tickets to the destination airport from BOS.
	 * @param baseTicketPrice The base price of the ticket.
	 */
	public void setBaseTicketPrice(double baseTicketPrice)
	{
		this.baseTicketPrice = baseTicketPrice;
	}
	
	/**
	 * Gets the number of luggage pieces the passenger is taking.
	 */
	public int getLuggageCount()
	{
		return this.luggageCount;
	}
	
	/**
	 * Sets the number of luggage pieces the passenger is taking.
	 * @param luggageCount The number of luggage pieces.
	 */
	public void setLuggageCount(int luggageCount)
	{
		this.luggageCount = luggageCount;
	}
	
	/**
	 * Calculates the final ticket price, factoring in the amount of luggage and departure time.
	 */
	public double calculateFinalTicketPrice()
	{
		// Get the base ticket price
		double price = this.getBaseTicketPrice();
		
		// If the passenger has more than one piece of luggage,
		// they need to be charged $15 for each additional piece
		if (this.getLuggageCount() > 1)
		{
			// Calculate the cost of the additional luggage and add it to the price
			price += (this.getLuggageCount() - 1) * 15;
		}
		
		// If flight departs at or after 5 PM, deduct $20 from the ticket price
		if (this.getDepartureTime() >= 1700)
		{
			price -= 20;
		}
		else if (this.getDepartureTime() >= 800)
		{
			price += 50;
		}
		
		return price;
	}
	
	/**
	 * Returns a string representation of this {@link Ticket}.
	 */
	public String toString()
	{
		// Instantiate a currency formatter to format the ticket prices
		NumberFormat currency = NumberFormat.getCurrencyInstance();
		
		// Instantiate a integer formatter to format 24-hour time as 4 digits
		NumberFormat time = NumberFormat.getIntegerInstance();
		time.setMinimumIntegerDigits(4);
		time.setMaximumIntegerDigits(4);
		
		// Make sure we don't have commas in the time
		time.setGroupingUsed(false);
		
		return
			Ticket.ORIGIN + "\t" +
			this.getDestination() + "\t\t" +
			time.format(this.getDepartureTime()) + "\t" +
			currency.format(this.getBaseTicketPrice()) + "\t\t" +
			this.getLuggageCount() + "\t" +
			currency.format(this.calculateFinalTicketPrice());
	}
}
