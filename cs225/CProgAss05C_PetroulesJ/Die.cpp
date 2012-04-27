#include "Die.h"
#include <cstdlib>

/*
    \class Die
    Represents a generic six-sided die.
 */

/*
    Constructs a new instance of the Die class with the specified face. The default is 1.
 */
Die::Die(int face)
{
    this->m_face = face;
}

/*
    Constructs a new instance of the Die class with the same face as the Die \a orig.
 */
Die::Die(const Die& orig)
{
    this->m_face = orig.m_face;
}

Die::~Die()
{
}

/*
    Gets the face value of the die.
 */
int Die::face() const
{
    return this->m_face;
}

/*
    Sets the face value of the die to \a face.
 */
void Die::setFace(int face)
{
    // If the value is out of range, correct it
    if (face < 1)
    {
        face = 1;
    }
    else if (face > Die::maxFace)
    {
        face = Die::maxFace;
    }

    this->m_face = face;
}

/*
    Rolls the die, settings its face to a random value between 1 and 6, and returns the face value.
 */
int Die::roll()
{
    return this->m_face = (rand() % Die::maxFace) + 1;
}