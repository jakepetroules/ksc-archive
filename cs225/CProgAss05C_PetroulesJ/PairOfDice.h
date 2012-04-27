/* 
 * File:   PairOfDice.h
 * Author: Jake Petroules
 *
 * Created on March 10, 2011, 11:21 AM
 */

#ifndef PAIROFDICE_H
#define	PAIROFDICE_H

#include "Die.h"

class PairOfDice
{
public:
    PairOfDice();
    PairOfDice(const PairOfDice& orig);
    virtual ~PairOfDice();
    int face1() const;
    void setFace1(int face);
    int face2() const;
    void setFace2(int face);
    int faces() const;
    void setFaces(int face1, int face2);
    int roll();
private:
    Die m_die1;
    Die m_die2;
};

#endif	/* PAIROFDICE_H */

