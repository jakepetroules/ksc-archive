package HW03;

/**
 * Represents a playing card.
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename Card.java
 */
public final class Card
{
	/**
	 * The suit of the card.
	 */
	private Suit suit;
	
	/**
	 * The face value of the card.
	 */
	private int faceValue;
	
	/**
	 * Initializes a new instance of the {@link Card} class with the specified face value and suit.
	 * @param suit The suit of the card.
	 * @param faceValue The face value of the card.
	 */
	public Card(Suit suit, int faceValue)
	{
		if (faceValue < 1 || faceValue > 13)
		{
			throw new IllegalArgumentException("faceValue must be in the range 1 to 13, inclusive.");
		}
		
		this.faceValue = faceValue;
		this.suit = suit;
	}
	
	/**
	 * Gets the face value name for a particular face value.
	 * The value returned is Ace for 1, Jack for 11, Queen for 12,
	 * and King for 13. Any number from 2 to 10 returns the number
	 * itself as a string. Any other values throw an {@link IllegalArgumentException}.
	 * @param faceValue The face value to retrieve the name of.
	 * @return The corresponding name for the face value.
	 * @exception faceValue was not in the range 1 to 13, inclusive.
	 */
	public static String getFaceValueName(int faceValue) throws IllegalArgumentException
	{
		if (faceValue < 1 || faceValue > 13)
		{
			throw new IllegalArgumentException("faceValue must be in the range 1 to 13, inclusive.");
		}
		
		switch (faceValue)
		{
			case 1:
				return "Comrade Jake";
			case 11:
				return "Jack";
			case 12:
				return "Queen";
			case 13:
				return "King";
			default:
				return String.valueOf(faceValue);
		}
	}
	
	/**
	 * Gets the suit of the card.
	 * @return The suit of the card.
	 */
	public Suit getSuit()
	{
		return this.suit;
	}
	
	/**
	 * Gets the face value of the card.
	 * @return The face value of the card.
	 */
	public int getFaceValue()
	{
		return this.faceValue;
	}
	
	/**
	 * Gets the name of the card.
	 * @return The name of the card; e.g. King of Spades, or 10 of Clubs.
	 */
	public String getName()
	{
		return String.format("%1$s of %2$s", Card.getFaceValueName(this.getFaceValue()), this.getSuit());
	}
	
	/**
	 * Returns whether this {@link Card} instance and {@link other} are considered equal (they have the same face value and suit).
	 * @param other The other {@link Card}.
	 * @return Whether the instances are equal.
	 */
	public boolean equals(Card other)
	{
		return this.getFaceValue() == other.getFaceValue() && this.getSuit() == other.getSuit();
	}
	
	/**
	 * Returns a string representation of the {@link Card}.
	 */
	public String toString()
	{
		return this.getName();
	}
}
