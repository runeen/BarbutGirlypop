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
        List<ICarte> peekCarti(int nrCarti);
        void shuffle();
    }
}
