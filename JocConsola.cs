using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbutGirlypop
{
    class JocConsola : IJoc
    {
        IMana[] jucatori;

        Stack<ICarte> stack0;
        Stack<ICarte> stack1;

        public JocConsola()
        {
            jucatori = new IMana[2];
            stack0 = new Stack<ICarte>();
            stack1 = new Stack<ICarte>();
        }

        private void RunRazboi()
        {
            Console.WriteLine("!!! RAZBOI !!!");
            //TODO: Fa asta functie separata, ideal fiecare posibilitate sa fie o funtie separata ca sa nu rescrii codul pt fiecare conditie lol
            int valRazboi = stack0.Peek().GetValue();

            int c = 0;

            while (jucatori[0].hasNext() && c < valRazboi)
            {
                stack0.Push(jucatori[0].popCarte(0));
                c++;
            }

            c = 0;
            while (jucatori[1].hasNext() && c < valRazboi)
            {
                stack1.Push(jucatori[1].popCarte(0));
                c++;
            }

            Console.ReadKey();
            RunTura();
        }

        //totul e stricat
        private void RunTura()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("p1 are {0} carti si p2 are {1} carti", jucatori[0].getLength(), jucatori[1].getLength());

            if(jucatori[0].getLength() <= 0 && jucatori[1].getLength() <= 0)
            {
                return;
            }

            stack0.Push(jucatori[0].popCarte(0));
            stack1.Push(jucatori[1].popCarte(0));

            Console.Write("p1: ");
            for (int i = 0; i < jucatori[0].getLength(); i++)
            {
                Console.Write('|');
            }
            stack0.Peek().PrintCarte();
            Console.Write("\np2: ");
            for (int i = 0; i < jucatori[1].getLength(); i++)
            {
                Console.Write('|');
            }
            stack1.Peek().PrintCarte();
            Console.Write("\n");

            StringBuilder output = new StringBuilder();

            Console.ReadKey();
            output = new StringBuilder();
            output.Append("Castiga: ");
            if (stack0.Peek().GetValue() > stack1.Peek().GetValue())
            {
                while(stack0.Count > 0)
                {
                    jucatori[0].addCarte(stack0.Pop());
                }
                while (stack1.Count > 0)
                {
                    jucatori[0].addCarte(stack1.Pop());
                }
                output.Append("p1");
                Console.WriteLine(output.ToString());
                Console.ReadKey();
            }
            else if (stack0.Peek().GetValue() < stack1.Peek().GetValue())
            {
                while (stack0.Count > 0)
                {
                    jucatori[1].addCarte(stack0.Pop());
                }
                while (stack1.Count > 0)
                {
                    jucatori[1].addCarte(stack1.Pop());
                }
                output.Append("p2");
                Console.WriteLine(output.ToString());
                Console.ReadKey();
            }
            else 
            {
                RunRazboi();
            }

        }


        public int RunJoc()
        {
            while (jucatori[0].getLength() > 0 && jucatori[1].getLength() > 0)
            {
                RunTura();
            }


            if(jucatori[0].getLength() > 0)
            {
                Console.WriteLine("A castigat p1");
                Console.ReadKey();
                return 0;
            }
            else
            {
                Console.WriteLine("A castigat p2");
                Console.ReadKey();
                return 1;
            }
        }

        private void tura()
        {

        }

        public void setJucatori(IMana mana1, IMana mana2)
        {
            jucatori[0] = mana1;
            jucatori[1] = mana2;
        }


    }
}
