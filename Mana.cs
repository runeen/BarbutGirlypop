using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbutGirlypop
{
    class Mana : IMana
    {

        public Stack<ICarte> stackCartiInJoc;

        List<ICarte> carti;
        public Mana() 
        {
            carti = new List<ICarte>();
            stackCartiInJoc = new Stack<ICarte>();
        }
        
        public Mana(List<ICarte> carti)
        {
            this.carti = carti;
            stackCartiInJoc = new Stack<ICarte>();
        }

        public int getLength()
        {
            return carti.Count;
        }

        public void addCarte(ICarte carte)
        {
            carti.Add(carte);
        }

        public ICarte popCarte(int poz)
        {
            ICarte carteScoasa = carti[poz];
            carti.RemoveAt(poz);
            return carteScoasa;
        }

        public List<ICarte> peekCarti(int numarCarti)
        {
            List<ICarte> cartiDeVazut = new List<ICarte>();
            for(int i = 0; i < numarCarti && i < carti.Count; i++)
            {
                cartiDeVazut.Add(carti[i]);
            }
            return cartiDeVazut;
        }

        public void shuffle(Random r)
        {
            ICarte temp;
            int randVal;
            for (int i = 0; i < carti.Count - 1; i++)
            {
                randVal = r.Next(i + 1, carti.Count);
                temp = carti[i];
                carti[i] = carti[randVal];
                carti[randVal] = temp;
            }
        }
        override
        public String ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < carti.Count; i++)
            {
                sb.Append(i + ". " + carti[i] + " \n");
            }
            return sb.ToString();
        }

        public bool hasNext()
        {
            return carti.Count > 0;
        }

        public void stackPush(ICarte carte)
        {
            stackCartiInJoc.Push(carte);
        }

        public ICarte stackPeek()
        {
            return stackCartiInJoc.Peek();
        }

        public ICarte stackPop()
        {
            return stackCartiInJoc.Pop();
        }

        public int stackCount()
        {
            return stackCartiInJoc.Count;
        }

        public void onRoundWin(IMana manaOpusa)
        {
            Suits suitManaOpusa = manaOpusa.stackPeek().GetType();
            Suits suitMana = this.stackPeek().GetType();

            if(WeaknessManager.compareSuits(suitMana, suitManaOpusa))
            {
                if(manaOpusa.hasNext())
                {
                    manaOpusa.stackPush(manaOpusa.popCarte(0));
                    Console.WriteLine("{0} este slab impotriva {1}!", suitManaOpusa, suitMana);
                }
            }
        }

    }

}
