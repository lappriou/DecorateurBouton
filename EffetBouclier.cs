using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateurBouton
{
    public class EffetBouclier : IBouton
    {
        public IBouton BoutonAvant { get; set; }

        public EffetBouclier(IBouton boutonAvant)
        {
            this.BoutonAvant = boutonAvant;

        }


        public int GetHauteur()
        {
            return BoutonAvant.GetHauteur();
        }

        public int GetLargeur()
        {
            return BoutonAvant.GetLargeur();

        }

        public int GetBouclier()
        {
            return BoutonAvant.GetBouclier() *2;
        }

        public int GetOpacite()
        {
            return BoutonAvant.GetOpacite();
        }
    }
}
