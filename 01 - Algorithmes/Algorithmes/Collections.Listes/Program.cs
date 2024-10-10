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

            // VARIABLES

            string saisieNomPrenom;
            char saisieOuiNon;

            string[] utilisateurs;
            utilisateurs = new string[] { "Mary Poppins" };

            string[] tableauTemporaire;

            // TRAITEMENT

            do
            {
                Console.WriteLine("\nSaisissez votre nom et prénom : ");
                saisieNomPrenom = Console.ReadLine() ?? " ";

                tableauTemporaire = utilisateurs;

                utilisateurs = new string[utilisateurs.Length + 1];
                tableauTemporaire.CopyTo(utilisateurs, 0);

                utilisateurs[utilisateurs.Length-1] = saisieNomPrenom;

                Console.WriteLine("\nSaisissez-vous ajouter un autre utilisateur ? (o/n)");
                saisieOuiNon = Console.ReadKey().KeyChar;
                
            }
            while (saisieOuiNon == 'o' || saisieOuiNon == 'O');


        }
    }
}
