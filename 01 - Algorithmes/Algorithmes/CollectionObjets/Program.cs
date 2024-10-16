
using Collection.Objets;

namespace Users.ConsoleApp.Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enregistrement d'utilisateurs (gestion avec Objet Métier).");

            // VARIABLES

            DateTime dateValide;
            DateTime ajd = DateTime.Now;
            string saisieDate;

            int age = 0;

            string saisieNomPrenom;

            string? metierCouleur = null;
            ConsoleKey yn;
            List<Utilisateur> utilisateurs = new();

            // TRAITEMENT

            do
            {
                try
                {
                    Console.WriteLine("Saisissez le nom et le prénom : ");
                    saisieNomPrenom = Console.ReadLine();

                    Console.WriteLine("Saisissez la date de naissance (jj/mm/yyyy) :");
                    saisieDate = Console.ReadLine();
                    
                    Utilisateur unUtilisateur = new Utilisateur(saisieNomPrenom, saisieDate);

                    if (unUtilisateur.IsMajeur())
                    {
                        Console.WriteLine("Saisissez le métier : ");
                        metierCouleur = Console.ReadLine() ?? "";
                        unUtilisateur.SetMetier(metierCouleur);
                    }

                    else
                    {
                        Console.WriteLine("Saisissez la couleur préférée : ");
                        metierCouleur = Console.ReadLine() ?? "";
                        unUtilisateur.SetCouleur(metierCouleur);
                    }

                    utilisateurs.Add(unUtilisateur);
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Voulez-vous saisir un autre utilisateur : O/N ?");
                yn = Console.ReadKey(true).Key;

            }
            while (yn == ConsoleKey.O);

            // AFFICHAGE

            foreach (Utilisateur utilisateur in utilisateurs)
            {
                Console.Write("Nom et Prénom: " + utilisateur.GetNomComplet() + " - ");
                Console.Write("Date de naissance (âge) : "
                    + utilisateur.GetDateDeNaissance()
                    + " (" + utilisateur.GetAge() + ")"
                    );
                Console.WriteLine(utilisateur.GetCouleurOuMetier());
            }

            /*List<Utilisateur> resultat = utilisateurs.FindAll(u => u.IsMajeur());

            foreach (Utilisateur u in utilisateurs)
            {
                if(u.IsMajeur())
                {
                    resultat.Add(u);
                }

            } */
        }
    }
}
