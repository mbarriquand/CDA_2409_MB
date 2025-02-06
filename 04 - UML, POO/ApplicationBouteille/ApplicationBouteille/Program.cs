using ClassLibraryBouteille;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // VERIFICATION DES BOUTEILLES 

            Bouteille b;
            
            b = new Bouteille();

            b = new Bouteille(3f, 2f, true);

            b = new Bouteille(0.5f, 0.25f);

            Bouteille clone = new Bouteille(b);


            
           // METHODES
           

           // bool okPourOuvrir = b.Ouvrir();


        }
    }
}
