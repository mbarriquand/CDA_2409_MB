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

            int temp = 0;
            int[] tableau = { 128, 64, 8, 512, 16, 32, 256 };

            // TRAITEMENT

            Console.Write("Soit un tableau : ");
            foreach (int item in tableau)
            {
                Console.Write(item.ToString() + " ");
            }

            for (int i = 0; i < tableau.Length; i++)
            {
                for (int j = 0; j < tableau.Length; j++)
                {
                    if (tableau[i] < tableau[j])
                    {
                        temp = tableau[i];
                        tableau[i] = tableau[j];
                        tableau[j] = temp;
                    }
                }
            }

            // AFFICHAGE

            Console.Write("\nSoit le même tableau trié dans l'ordre croissant :");

            for (int i = 0; i < tableau.Length; i++)
            {
                Console.Write((tableau[i]) + " ");
            }
        }
    }
}

