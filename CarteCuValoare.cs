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
