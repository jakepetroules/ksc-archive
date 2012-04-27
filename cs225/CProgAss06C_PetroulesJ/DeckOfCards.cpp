#include "DeckOfCards.h"
#include <cstdlib>

DeckOfCards::DeckOfCards()
{
    this->fill();
}

DeckOfCards::~DeckOfCards()
{
}

void DeckOfCards::fill()
{
    for (int i = 0; i < this->m_cards.size(); i++)
    {
        const Card *card = this->m_cards.at(i);
        if (card)
        {
            delete card;
        }
    }

    this->m_cards.clear();

    for (int i = 0; i < 4; i++)
    {
        for (int j = 1; j <= 13; j++)
        {
            this->m_cards.push_back(new Card(static_cast<Card::Suit>(i), j));
        }
    }
}

int DeckOfCards::count() const
{
    return this->m_cards.size();
}

const Card* DeckOfCards::deal()
{
    const Card *card = this->m_cards.front();
    this->m_cards.erase(this->m_cards.begin());
    return card;
}

void DeckOfCards::shuffle()
{
    for (int x = 0; x < 100; x++)
    {
        for (int i = 1; i < this->m_cards.size(); i++)
        {
            bool swap = (rand() % 100) > 50;
            if (swap)
            {
                Card *card1 = this->m_cards.at(i);
                Card *card2 = this->m_cards.at(i - 1);
                this->m_cards.at(i) = card2;
                this->m_cards.at(i - 1) = card1;
            }
        }
    }
}