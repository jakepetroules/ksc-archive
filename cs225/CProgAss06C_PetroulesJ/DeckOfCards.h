#ifndef DECKOFCARDS_H
#define	DECKOFCARDS_H

#include "Card.h"
#include <vector>

class DeckOfCards
{
public:
    DeckOfCards();
    virtual ~DeckOfCards();
    void fill();
    int count() const;
    const Card* deal();
    void shuffle();
    
private:
    std::vector<Card*> m_cards;
};

#endif	/* DECKOFCARDS_H */

