

using System.Data.Common;
using System.Xml.XPath;

namespace ExerciceCollections
{

    /* CONSIGNES
     * 
    Implémenter le programme suivant : 

    Au démarrage, il n'y a aucun utilisateur enregistré.

    ## Déroulement du programme

    1. Le programme demande à l'utilisateur de saisir un nom et un prénom.
      - L’utilisateur saisit un nom et un prénom.

    2. Le programme demande à l'utilisateur de saisir la date de naissance.
      - L'utilisateur saisit la date de naissance.

    3. Le programme calcule l'âge de la personne en cours d'ajout.
      - Si l’âge est supérieur ou égal à 18 (majeur)
            - Le programme demande à l'utilisateur de saisir son métier.
      - Si l’âge est inférieur à 18 (mineur)
            - Le programme demande à l'utilisateur de saisir sa couleur préférée.

    4. Lorsque toutes les informations sont saisies
      - Le programme enregistre l'utilisateur

    5. Le programme demande à l'utilisateur s'il souhaite ajouter une autre personne.
      - Si oui
            - Retour à l'étape 1 (saisir nom et prénom)
      - Si non
            - Afficher tous les utilisateurs enregistrés en respectant ce format :
            - Nom Prénom - Date de naissance (âge) - Métier/Couleur préférée

    6. Le programme remercie l'utilisateur et se termine      */
    internal class Program
    {
        static void Main(string[] args)
        {

            // VARIABLES

            string nomUtilisateur;

            DateTime ajd = DateTime.Today;
            bool dateValide = true;
            DateOnly ddnFormat = new DateOnly();

            string ddn = " ";
            int age = 0;

            string infos = " ";
            // string couleur = " ";

            char yn;

            List<string> listingUtilisateurs = new List<string>();
            List<int> listingAge = new List<int>();
            List<DateOnly> listingDdn = new List<DateOnly>();
            List<string> listingInfos = new List<string>();

            // TRAITEMENT

            Console.WriteLine("Bienvenue, nous sommes le : " + ajd.ToString("d"));

            do
            {
                Console.WriteLine("Saisissez votre nom et votre prénom :");
                nomUtilisateur = Console.ReadLine() ?? "";

                
                do
                {
                    Console.WriteLine("Saisissez votre date de naissance (jj/mm/aaaa) :");
                    ddn = Console.ReadLine() ?? "";
                    

                    try
                    {
                        ddnFormat = DateOnly.Parse(ddn);
                        age = ajd.Year - ddnFormat.Year;

                        if (age < 18)
                        {
                            Console.WriteLine("Saisissez votre couleur préférée :");
                        }

                        else
                        {
                            Console.WriteLine("Saisissez votre métier :");
                        }

                            infos = Console.ReadLine() ?? "";
                    }

                    catch (Exception)
                    {
                        Console.WriteLine("Date invalide");
                        dateValide = false;
                    }

                } while (!dateValide);

                listingUtilisateurs.Add(nomUtilisateur);
                listingAge.Add(age);
                listingDdn.Add(ddnFormat);
                listingInfos.Add(infos);
                

                Console.WriteLine("\nSaisissez-vous ajouter un autre utilisateur ? (o/n)");
                yn = Console.ReadKey(true).KeyChar;

            }

            while (yn == 'o' || yn == 'O');

            // AFFICHAGE

            for (int i = 0; i < listingUtilisateurs.Count; ++i)
            {
                Console.Write("\nUtilisateur : " + listingUtilisateurs[i] + "\t");
                Console.Write("Date de naissance (âge) : " + listingDdn[i] + " (" + listingAge[i] + ")\t");

                if (ajd.Year - ddnFormat.Year >= 18)
                {
                    Console.Write("Metier :" + listingInfos[i]);
                }

                else 
                {
                    Console.Write("Couleur préférée : " + listingInfos[i]);
                } 
            }

            Console.WriteLine("\n\nMerci d'avoir utilisé le programme.");

        }
    }
}
