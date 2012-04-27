#ifndef CARD_H
#define	CARD_H

#include <string>
#include <sstream>

class Card
{
public:
    enum Suit
    {
        Diamonds,
        Clubs,
        Hearts,
        Spades
    };
    
    Card(Suit suit, int face);
    Card(const Card& orig);
    virtual ~Card();
    Suit suit() const;
    void setSuit(Suit suit);
    int face() const;
    void setFace(int face);
    std::string toString() const;
    
private:
    Suit m_suit;
    int m_face;
};

#endif	/* CARD_H */

