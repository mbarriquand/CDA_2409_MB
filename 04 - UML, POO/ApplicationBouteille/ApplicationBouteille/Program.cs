using ClassLibraryBouteille;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenue l'application bouteille");
            

            // VERIFICATION DES BOUTEILLES 

            Bouteille b;

            Bouteille bouteilleBis;
            
            b = new Bouteille();

            b = new Bouteille(3f, 2f, true);

            b = new Bouteille(0.5f, 0.25f);

            bouteilleBis = new Bouteille(0.5f, 0.5f, true);

            Bouteille clone = new Bouteille(b);


            // bool testOuvrir = b.Ouvrir();

            // bool testFermer = b.Fermer();

            bool testRemplir = bouteilleBis.Remplir();

            bool testVider = bouteilleBis.Vider();

            // bool testRemplirPartiellement = bouteilleBis.RemplirPartiellement(-1.6f);

            
        }
    }
}
