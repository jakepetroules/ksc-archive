#ifndef DIE_H
#define	DIE_H

class Die
{
public:
    static const int maxFace = 6;

    Die(int face = 1);
    Die(const Die& orig);
    virtual ~Die();
    int face() const;
    void setFace(int face);
    int roll();
private:
    int m_face;
};

#endif