package HW03;

/**
 * Demonstrates the {@link DeckOfCards} class, which encapsulates a deck of playing cards, providing
 * methods to fill the deck with a card of each face value and suit, sort and print them.
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename HW03.java
 */
public class HW03
{
	public static void main(String[] args)
	{
		// Instantiate the deck
		DeckOfCards deck = new DeckOfCards();
		
		// Fill it with cards and print the contents of the deck
		deck.fill();
		System.out.println(deck);
		
		// Shuffle and print again
		deck.shuffle();
		System.out.println(deck);
	}
}
