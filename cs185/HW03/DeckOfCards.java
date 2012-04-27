package HW03;

import java.util.*;

/**
 * Represents a deck of playing cards.
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename DeckOfCards.java
 */
public final class DeckOfCards
{
	/**
	 * The number of cards in standard deck.
	 */
	public final int DECK_CARD_COUNT = 52;

	/**
	 * The cards in the deck.
	 */
	private Card[] cards;

	/**
	 * Initializes a new instance of the {@link DeckOfCards} class.
	 */
	public DeckOfCards()
	{
		this.cards = new Card[DECK_CARD_COUNT];
	}

	/**
	 * Fills the deck of cards with a card of each face value and suit.
	 */
	public void fill()
	{
		Suit[] suits = Suit.values();

		for (int i = 0; i < suits.length; i++)
		{
			for (int j = 0; j < DECK_CARD_COUNT / suits.length; j++)
			{
				this.cards[(i * DECK_CARD_COUNT / suits.length) + j] = new Card(suits[i], j + 1);
			}
		}
	}

	/**
	 * Shuffles the cards in the deck.
	 */
	public void shuffle()
	{
		Random random = new Random();

		int numberOfSwaps = (random.nextInt(10) + 1) * DECK_CARD_COUNT;

		while (numberOfSwaps-- > 0)
		{
			int index1 = random.nextInt(DECK_CARD_COUNT);
			int index2 = random.nextInt(DECK_CARD_COUNT);

			if (random.nextFloat() > 0.5f)
			{
				Card temp = this.cards[index1];
				this.cards[index1] = this.cards[index2];
				this.cards[index2] = temp;
			}
		}
	}

	/**
	 * Returns a string representation of the {@link DeckOfCards}.
	 */
	public String toString()
	{
		StringBuilder result = new StringBuilder();
		
		for (int i = 0; i < this.cards.length; i++)
		{
			result.append(this.cards[i] + "\n");
			
			int cardsLeft = (this.cards.length - i) - 1;
			result.append((cardsLeft > 0 ? cardsLeft : "No") + " more card" + (cardsLeft != 1 ? "s" : "") + " to go!\n");
		}
		
		return result.toString();
	}
	
	/**
	 * Returns whether all cards are present in the deck.
	 * @return Whether all cards are present in the deck.
	 */
	public boolean isDeckComplete()
	{
		Suit[] suits = Suit.values();

		for (int i = 0; i < suits.length; i++)
		{
			for (int j = 0; j < DECK_CARD_COUNT / suits.length; j++)
			{
				if (!this.containsCard(new Card(suits[i], j + 1)))
				{
					return false;
				}
			}
		}
		
		return true;
	}
	
	/**
	 * Returns whether a card is present in the deck.
	 * @param card The card to check for.
	 * @return Whether {@link card} is present in the deck.
	 */
	private boolean containsCard(Card card)
	{
		for (int i = 0; i < DECK_CARD_COUNT; i++)
		{
			if (this.cards[i].equals(card))
			{
				return true;
			}
		}
		
		return false;
	}
}
