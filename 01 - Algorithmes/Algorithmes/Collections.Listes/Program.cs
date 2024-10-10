using System.Collections;

namespace Collections.Listes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* CONSIGNES :
            Au démarrage, il n'y a aucun utilisateur enregistré.
 
            1. Le programme demande à l'utilisateur de saisir un nom et un prénom.
	            - L’utilisateur saisit un nom et un prénom.
 
            2. Lorsque toutes les informations sont saisies
	            - Le programme enregistre l'utilisateur
 
            3. Le programme demande à l'utilisateur s'il souhaite ajouter une autre personne.
	            - Si oui
		            - Retour à l'étape 1 (saisir nom et prénom)
	            - Si non
		            - Afficher tous les utilisateurs enregistrés
 
            4. Le programme se termine
            */

            Console.WriteLine("Enregistrement de nouveaux utilisateurs");

            // VARIABLES

            List<string> utilisateurs = new List<string>(); // liste fortement typée

            utilisateurs.Add("toto"); // augmente la taille de la collection de 1 et ajoute l'élément à la fin de la collection
            utilisateurs.Add("toto2");

            utilisateurs.AddRange(["toto3", "toto4"]);

            utilisateurs.Insert(2, "titi");
            utilisateurs.InsertRange(1, ["tata", "tutu"]);

            utilisateurs.Prepend("riri"); // ajout au début
            utilisateurs.Append("fifi"); // ajout à la fin

            utilisateurs.Remove("tata");
            utilisateurs.RemoveAll(x => x == "tata"); // predicat
            utilisateurs.RemoveRange(1, 2); 

            string saisieNomPrenom;

            char saisieOuiNon;
            
            // TRAITEMENT

            do
            {
                Console.WriteLine("\nSaisissez un nom et un prénom : ");
                
                saisieNomPrenom = Console.ReadLine() ?? " ";

                utilisateurs.Add(saisieNomPrenom);

                Console.WriteLine("\nSaisissez-vous ajouter un autre utilisateur ? (o/n)");
                saisieOuiNon = Console.ReadKey(true).KeyChar;
                
            }
            while (saisieOuiNon == 'o' || saisieOuiNon == 'O');

            for (int i = 0; i < utilisateurs.Count; i++)
            {
                Console.WriteLine(utilisateurs[i]);
            }

            foreach (string personne in utilisateurs)
            {
                Console.WriteLine(personne);
            }
            
        }
    }
}
