#include "PairOfDice.h"
#include "Die.h"

/*
    \class PairOfDice
    Represents a pair of two generic six-sided die.
 */

/*
    Constructs a new instance of the PairOfDice class with the internal die having a face value of 1.
 */
PairOfDice::PairOfDice()
{
}

/*
    Constructs a new instance of the PairOfDice class with the same face values as the PairOfDice \a orig.
 */
PairOfDice::PairOfDice(const PairOfDice& orig)
{
    this->m_die1.setFace(orig.m_die1.face());
    this->m_die2.setFace(orig.m_die2.face());
}

PairOfDice::~PairOfDice()
{
}

/*
    Gets the face value of the first die.
 */
int PairOfDice::face1() const
{
    return this->m_die1.face();
}

/*
    Sets the face value of the first die to \a face.
 */
void PairOfDice::setFace1(int face)
{
    this->m_die2.setFace(face);
}

/*
    Gets the face value of the second die.
 */
int PairOfDice::face2() const
{
    return this->m_die2.face();
}

/*
    Sets the face value of the second die to \a face.
 */
void PairOfDice::setFace2(int face)
{
    this->m_die2.setFace(face);
}

/*
    Gets the sum of the face values of the first and second die.
 */
int PairOfDice::faces() const
{
    return this->m_die1.face() + this->m_die2.face();
}

/*
    Sets the face values of the first and second die to \a face1 and \a face2, respectively.
 */
void PairOfDice::setFaces(int face1, int face2)
{
    this->setFace1(face1);
    this->setFace2(face2);
}

/*
    Rolls the two internal die, settings their faces to random values between 1 and 6,
    and returns the sum of the face values.
 */
int PairOfDice::roll()
{
    return this->m_die1.roll() + this->m_die2.roll();
}