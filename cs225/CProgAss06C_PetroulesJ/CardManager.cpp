#include <cstdlib>
#include <iostream>
#include "DeckOfCards.h"

using namespace std;

int main(int argc, char** argv)
{
    cout << "Creating deck..." << endl;
    DeckOfCards cards;

    cout << "Shuffling deck..." << endl;
    cards.shuffle();

    cout << "Dealing cards..." << endl;
    while (cards.count() > 0)
    {
        const Card *card = cards.deal();
        cout << "Dealt: " << card->toString() << endl;
        cout << cards.count() << " remaining" << endl;
        delete card;
    }

    return 0;
}

