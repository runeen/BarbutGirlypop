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

        public JocConsola()
        {
            jucatori = new IMana[2];
        }

        private void RunRazboi()
        {
            Console.WriteLine("!!! RAZBOI !!!");
            //TODO: Fa asta functie separata, ideal fiecare posibilitate sa fie o funtie separata ca sa nu rescrii codul pt fiecare conditie lol
            int valRazboi = jucatori[0].stackPeek().GetValue();

            int c = 0;

            while (jucatori[0].hasNext() && c < valRazboi)
            {
                jucatori[0].stackPush(jucatori[0].popCarte(0));
                c++;
            }

            c = 0;
            while (jucatori[1].hasNext() && c < valRazboi)
            {
                jucatori[1].stackPush(jucatori[1].popCarte(0));
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

            if(jucatori[0].getLength() <= 0 || jucatori[1].getLength() <= 0)
            {
                return;
            }

            jucatori[0].stackPush(jucatori[0].popCarte(0));
            jucatori[1].stackPush(jucatori[1].popCarte(0));

            Console.Write("p1: ");
            for (int i = 0; i < jucatori[0].getLength(); i++)
            {
                Console.Write('|');
            }
            jucatori[0].stackPeek().PrintCarte();
            Console.Write("\np2: ");
            for (int i = 0; i < jucatori[1].getLength(); i++)
            {
                Console.Write('|');
            }
            jucatori[1].stackPeek().PrintCarte();
            Console.Write("\n");

            StringBuilder output = new StringBuilder();

            Console.ReadKey();
            output = new StringBuilder();
            output.Append("Castiga: ");
            if (jucatori[0].stackPeek().GetValue() > jucatori[1].stackPeek().GetValue())
            {
                jucatori[0].onRoundWin(jucatori[1]);   
                while (jucatori[0].stackCount() > 0)
                {
                    jucatori[0].addCarte(jucatori[0].stackPop());
                }
                while (jucatori[1].stackCount() > 0)
                {
                    jucatori[0].addCarte(jucatori[1].stackPop());
                }
                output.Append("p1");
                Console.WriteLine(output.ToString());
                Console.ReadKey();
            }
            else if (jucatori[0].stackPeek().GetValue() < jucatori[1].stackPeek().GetValue())
            {
                jucatori[1].onRoundWin(jucatori[0]);
                while (jucatori[0].stackCount() > 0)
                {
                    jucatori[1].addCarte(jucatori[0].stackPop());
                }
                while (jucatori[1].stackCount() > 0)
                {
                    jucatori[1].addCarte(jucatori[1].stackPop());
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
