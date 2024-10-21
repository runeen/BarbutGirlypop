using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbutGirlypop
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarte test = new CarteCuValoare(Suits.Clubs, 12);

            Console.WriteLine(test.ToString());

            test = new CarteJoker(Suits.Diamonds);

            Console.WriteLine(test.ToString());

            Console.ReadKey();
        }
    }
}
