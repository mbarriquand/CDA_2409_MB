namespace TriTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* CONSIGNES :
             * Nous désignerons par a1, a2, …, aN les éléments d’un tableau à trier par ordre croissant.
             * Exemple: [128, 64, 8, 512, 16, 32, 256]
             * On commence par chercher l’indice du plus petit des éléments, soit j cet indice.
             * On permute alors les valeurs de a1 (128) et aj (8).
             * Le tableau devient [8, 64, 128, 512, 16, 32, 256].
             * On cherche ensuite l’indice du plus petit des éléments entre a2 et aN et on permute avec a2.
             * Le tableau devient [8, 16, 128, 512, 64, 32, 256].
             * On cherche ensuite l’indice du plus petit des éléments a3, a4, …, aN etc… */

            Console.WriteLine("Exercice 5.4 : Tri d’un tableau");

            // VARIABLES

            int stockage;
            int indice = 0;
            int temp = 0;
            int[] tableau = { 128, 64, 8, 512, 16, 32, 256 };

            // TRAITEMENT

            /* affichage du tableau avant le tri */

            Console.Write("Soit un tableau : ");
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.Write(tableau[i] + " ");
            }

            Console.WriteLine();

            /* tri du tableau */

            for (int i = 0; i < tableau.Length; i++)
            {
                stockage = int.MaxValue;

                for (int j = i; j < tableau.Length; j++)
                {
                    if (tableau[j] < stockage)
                    {
                        stockage = tableau[j];
                        indice = j;
                    }
                
                }

                    temp = tableau[indice];
                    tableau[indice] = tableau[i];
                    tableau[i] = temp;
            }

            // AFFICHAGE

            Console.Write("Soit le même tableau trié dans l'ordre croissant : ");

            for (int i = 0; i < tableau.Length; i++)
            {
                Console.Write((tableau[i]) + " ");
            }

            Console.WriteLine();
            Console.Write("Soit le même tableau trié dans l'ordre croissant (mais avec un foreach) : ");

            foreach (int nbr in tableau) // 
            {
                Console.Write(nbr + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Programme terminé, appuyer sur n'importe quelle touche pour quitter.");
            Console.ReadLine();
        }
    }
}

