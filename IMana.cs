using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbutGirlypop
{
    interface IMana
    {
        void addCarte(ICarte carte);
        ICarte  popCarte(int pozitie);
        void stackPush(ICarte carte);
        ICarte stackPeek();
        ICarte stackPop();
        int stackCount();
        void shuffle(Random r);
        int getLength();
        string ToString();
        bool hasNext();
    }
    enum Suits
    {
        Clubs,
        Hearts,
        Spades,
        Diamonds
    }
}
