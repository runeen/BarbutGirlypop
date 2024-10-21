using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbutGirlypop
{
    class Mana : IMana
    {
        List<ICarte> carti;
        public Mana() { }
        
        public Mana(List<ICarte> carti)
        {
            this.carti = carti;
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

        //TODO: fa asta sa mearga
        public void shuffle()
        {
            Random.Shared.Shuffle(carti);
        }

    }   

}
