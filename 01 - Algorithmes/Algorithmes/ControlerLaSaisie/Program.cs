/* CONSIGNES 
L’utilisateur est invité à saisir son prénom.

Le programme affiche ensuite “Bonjour” suivi du prénom saisi.

Le prénom doit contenir au moins 2 caractères.

Si le prénom contient moins de 2 caractères, l’utilisateur doit recommencer la saisie.

L’utilisateur dispose d’un nombre d’essai illimité. */

using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Exercice 3a.1 : Contrôler la saisie");

        // VARIABLES

        string ?prenom;
        string formatPrenom = @"^[a-zA-Z]{2,32}$";

        // TRAITEMENT
        
        try
        {

            do
            {
                Console.WriteLine("Saisissez votre prénom :");
                prenom = Console.ReadLine();
            }

            while (/* prenom.Length < 2 && */ !Regex.IsMatch(prenom, formatPrenom)); // renvoie un booléen
                 //cette verification devient redondante                          // Regex.isMatch compare la chaîne saisie et celle attendue

            Console.WriteLine("Bonjour " + prenom);
        }

        catch (Exception ex)
        {
            Console.WriteLine("Contactez le service informatique.");
        }
    }
}