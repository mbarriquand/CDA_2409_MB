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
            int solde = 0;
            int prixRepas = 4;
            bool utilisateurExistant = false;
            bool soldeSuffisant = true;

            string[] tableauUtilisateur = { "WAFAE", "REMI", "KARAN", "ALLAN", "MARIE" };
            int[] tableauSolde = { 25, 10, 4, 2, 0 };

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
                        solde = tableauSolde[i];
                        soldeSuffisant = true;
                    }

                    else
                    {
                        soldeSuffisant = false;
                    }

                }
            }

            // AFFICHAGE

            if (utilisateurExistant && soldeSuffisant)
            {
                Console.WriteLine("Repas réglé.\t Nouveau solde : " + solde);
            }

            else if (utilisateurExistant && !soldeSuffisant)
            {
                Console.WriteLine("Le solde de l'utilisateur " + utilisateur + " est insuffisant.");
            }

            else
            {
                Console.WriteLine("L'utilisateur " + utilisateur + " n'existe pas dans la base.");
            }
        }
    }
}
