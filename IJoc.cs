using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbutGirlypop
{
    interface IJoc
    {
        int RunJoc();
        void setJucatori(IMana mana1, IMana mana2);
    }
}
