using System.Reflection.Metadata;

namespace ApplicationBouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application Bouteille");

            // VERIFICATION DES BOUTEILLES

            Bouteille maBouteille = new Bouteille();

            Bouteille petiteBouteille = new Bouteille(0.5f, 0.5f, false);

            Bouteille petiteBouteilleClonee = new Bouteille(petiteBouteille);


            bool okPourOuvrir = petiteBouteille.Ouvrir();

            bool okPourOuvrirBis = petiteBouteille.Ouvrir();

        }
    }
}
