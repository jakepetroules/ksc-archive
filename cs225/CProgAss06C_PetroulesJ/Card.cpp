#include "Card.h"

Card::Card(Suit suit, int face)
    : m_suit(suit), m_face(face)
{
}

Card::Card(const Card& orig)
{
    this->m_suit = orig.m_suit;
    this->m_face = orig.m_face;
}

Card::~Card()
{
}

Card::Suit Card::suit() const
{
    return this->m_suit;
}

void Card::setSuit(Suit suit)
{
    this->m_suit = suit;
}

int Card::face() const
{
    return this->m_face;
}

void Card::setFace(int face)
{
    this->m_face = face;
}

std::string Card::toString() const
{
    std::stringstream sstream;

    switch (this->m_face)
    {
        case 1:
            sstream << "Ace";
            break;
        case 2:
            sstream << "Two";
            break;
        case 3:
            sstream << "Three";
            break;
        case 4:
            sstream << "Four";
            break;
        case 5:
            sstream << "Five";
            break;
        case 6:
            sstream << "Six";
            break;
        case 7:
            sstream << "Seven";
            break;
        case 8:
            sstream << "Eight";
            break;
        case 9:
            sstream << "Nine";
            break;
        case 10:
            sstream << "Ten";
            break;
        case 11:
            sstream << "Jack";
            break;
        case 12:
            sstream << "Queen";
            break;
        case 13:
            sstream << "King";
            break;
    }

    switch (this->m_suit)
    {
        case Diamonds:
            sstream << " of Diamonds";
            break;
        case Hearts:
            sstream << " of Hearts";
            break;
        case Clubs:
            sstream << " of Clubs";
            break;
        case Spades:
            sstream << " of Spades";
            break;
    }

    return sstream.str();
}