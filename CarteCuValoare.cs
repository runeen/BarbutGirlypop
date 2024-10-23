using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbutGirlypop
{
    class CarteCuValoare : ICarte
    {

        private Suits suit;
        private int value;

        public CarteCuValoare(Suits suit, int value)
        {
            if (value == 1) value = 11;
            this.suit = suit;
            this.value = value;
        }

        public Suits GetType()
        {
            return suit;
        }
        
        public int GetValue()
        {
            return value;
        }


        public void PrintCarte()
        {
            if (value == 11)      Console.Write("Ace");
            else if (value == 12) Console.Write("Jack");
            else if (value == 13) Console.Write("Queen");
            else if (value == 14) Console.Write("King");
            else                  Console.Write(value.ToString());

            Console.Write(" of ");

            if(suit == Suits.Diamonds)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if(suit == Suits.Hearts)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if(suit == Suits.Spades)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.Write(suit.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }

        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (value == 11)       sb.Append("Ace");
            else if (value == 12) sb.Append("Jack");
            else if (value == 13) sb.Append("Queen");
            else if (value == 14) sb.Append("King");
            else                  sb.Append(value.ToString());

            sb.Append(" of ");

            sb.Append(suit.ToString());

            return sb.ToString();
        }
    }

}
