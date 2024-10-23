using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbutGirlypop
{
    class CarteJoker : ICarte
    {
        Suits color;
        public CarteJoker(Suits suit)
        {
            if(suit == Suits.Clubs || suit == Suits.Spades)
            {
                this.color = Suits.Spades;
            }
            else
            {
                this.color = Suits.Hearts;
            }
        }

        public Suits GetType()
        {
            return color;
        }

        public int GetValue()
        {
            return 15;
        }
        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if(color == Suits.Spades)
            {
                sb.Append("black");
            }
            else
            {
                sb.Append("red");
            }

            sb.Append(" JOKER");

            return sb.ToString();
        }

        public void PrintCarte()
        {
            if (color == Suits.Spades)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("BLACK");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("RED");
            }

            Console.Write(" JOKER");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
