using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbutGirlypop
{
    interface ICarte
    {
        Suits GetType();
        int GetValue();

        string ToString();
    }
    enum Suits
    {
        Clubs,
        Hearts,
        Spades,
        Diamonds
    }
}
