using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateurBouton
{
    public interface IBouton
    {
        int GetHauteur();
        int GetLargeur();

        int GetBouclier();

        int GetOpacite();
       
    }
}
