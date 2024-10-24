using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbutGirlypop
{
    class WeaknessManager
    {
        public static bool compareSuits(Suits a, Suits b)
        {
            if (a == Suits.Hearts && b == Suits.Diamonds) return true;
            if (a == Suits.Spades && b == Suits.Clubs) return true;
            if (a == Suits.Clubs && b == Suits.Hearts) return true;
            if (a == Suits.Diamonds && b == Suits.Spades) return true;

            return false;
        }
    }
}
