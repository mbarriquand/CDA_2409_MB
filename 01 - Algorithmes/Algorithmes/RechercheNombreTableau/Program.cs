namespace RechercheNombreTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* CONSIGNES
            Soit un tableau de nombres entier triés par ordre croissant.

            Exemple: [8, 16, 32, 64, 128, 256, 512]

            Chercher si un nombre donné N figure parmi les éléments.

            Si oui, afficher la valeur de l’indice correspondant. Sinon, afficher « Nombre non trouvé ». */

            Console.WriteLine("Exercice 5.1 : Rechercher un nombre dans un tableau :");

            // VARIABLES

            int[] tableau = [8, 16, 32, 64, 128, 256, 512];
            int N;
            int indiceCase = -1;

            // TRAITEMENT

            Console.WriteLine("Verifiez si un nombre se trouve dans le tableau");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < tableau.Length; i++)
            {
                indiceCase++;

                if (N == tableau[i])
                {
                    Console.WriteLine("Le nombre " + N + " figure dans la case " + indiceCase + " du tableau.");
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Le nombre " + N + " ne figure pas dans le tableau.");
                    System.Environment.Exit(1);
                }
            }
        }
    }
}
