namespace BarnabeFaitSesCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* CONSIGNES
                       
            Barnabé fait ses courses dans plusieurs magasins.

            Dans chacun, il dépense 1 € de plus que la moitié de ce qu’il possédait en entrant.

            Dans le dernier magasin, il dépense le solde.

            Soit la somme S dont il disposait au départ (S > 1 €).

            Représenter l’algorithme permettant de trouver le nombre de magasins dans lesquels il a acheté. */

            
            Console.WriteLine("Exercice 3a.7 : Barnabé fait ses courses :");

            // VARIABLES

            double S;
            double sMoitie;
            int nombreDeMagasins = 0;

            // TRAITEMENT

            Console.WriteLine("Quel est le budget de Barnabé ?");
            S = double.Parse(Console.ReadLine());

            while ( S != 0 )
            {
                sMoitie = S / 2;
                S = sMoitie - 1;

                if ( S <  0 )
                {
                    S = 0;
                }

                nombreDeMagasins++;
            }

            Console.WriteLine("Barnabé a fait ses courses dans " + nombreDeMagasins + " magasins");
              
        }
    }
}
