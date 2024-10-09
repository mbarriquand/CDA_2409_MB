using System.ComponentModel.Design;

namespace JalonAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jalon :");

            // VARIABLES
            
            string utilisateur;            
            int prixRepas = 4;
            bool utilisateurExistant = false;

            string[] tableauUtilisateur = { "WAFAE", "REMI", "KARAN", "ALLAN", "MARIE" };
            int[] tableauSolde = {25, 10, 4, 2, 0};

            // TRAITEMENT

            Console.WriteLine("Saisissez le nom de l'utilisateur");
            utilisateur = Console.ReadLine() ?? " ";
            utilisateur = utilisateur.ToUpper() ?? " ";

            for (int i = 0; i < tableauUtilisateur.Length; i++)
            {
                if (utilisateur == tableauUtilisateur[i])
                {
                    utilisateurExistant = true;

                    if (tableauSolde[i] - prixRepas >= 0)
                    {
                            tableauSolde[i] -= prixRepas;
                            Console.WriteLine("Repas réglé.\t Nouveau solde : " + tableauSolde[i]);
                    }

                    else
                    {
                           Console.WriteLine("Le solde de l'utilisateur " + utilisateur + " est insuffisant.");
                    }

                }
            } 

            if (!utilisateurExistant)
            {
            Console.WriteLine("L'utilisateur " + utilisateur + " n'existe pas dans la base.");
            }
        }
    }
}
