using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateurBouton
{
    public class EffetGrossir : IBouton
    {
        public IBouton BoutonAvant { get; set; }

        public EffetGrossir(IBouton boutonAvant)
        {
            this.BoutonAvant = boutonAvant;

        }


        public int GetHauteur()
        {
            return BoutonAvant.GetHauteur() * 2;
        }

        public int GetLargeur()
        {
            return BoutonAvant.GetLargeur() * 2;

        }

        public int GetBouclier()
        {
            return BoutonAvant.GetBouclier();
        }

        public int GetOpacite()
        {
            return BoutonAvant.GetOpacite();
        }
    }
}
