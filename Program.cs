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
            Random r = new Random();
            List<ICarte> lista1 = new List<ICarte>();
            List<ICarte> lista2 = new List<ICarte>();

            for(int i = 2; i < 14; i++)
            {
                lista1.Add(new CarteCuValoare(Suits.Clubs, i));
                lista1.Add(new CarteCuValoare(Suits.Diamonds, i));
                lista2.Add(new CarteCuValoare(Suits.Spades, i));
                lista2.Add(new CarteCuValoare(Suits.Hearts, i));
            }

            lista1.Add(new CarteJoker(Suits.Clubs));
            lista2.Add(new CarteJoker(Suits.Hearts));

            IMana mana1 = new Mana(lista1);
            IMana mana2 = new Mana(lista2);

            mana1.shuffle(r);
            mana2.shuffle(r);


            Console.WriteLine(mana1);
            Console.WriteLine(mana2);

            IJoc joc = new JocConsola();

            joc.setJucatori(mana1, mana2);

            joc.RunJoc();

            Console.ReadKey();
        }
    }
}
