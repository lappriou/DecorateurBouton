using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateurBouton
{
    public class Bouton : IBouton
    {
        int hauteur;
        int largeur;
        int bouclier;
        int opacite;

        public Bouton(int haut, int lar, int boucli, int opa)
        {
            this.hauteur = haut;
            this.largeur = lar;
            this.bouclier = boucli;
            this.opacite = opa;
        }


        public int GetHauteur()
        {
            return hauteur;
        }

        public int GetLargeur()
        {
            return largeur;
            
        }

        public int GetOpacite()
        {
            return opacite;
        }

        public int GetBouclier()
        {
            return bouclier;
        }

    }
}
