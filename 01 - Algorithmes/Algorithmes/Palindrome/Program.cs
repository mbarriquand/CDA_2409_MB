using System.Reflection.PortableExecutable;
using System.Linq;
using System.Drawing;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* CONSIGNES : 
             * Un palindrome est une chaîne de caractères que l’on peut lire identiquement de droite à gauche, et gauche à droite.
             * Par exemple:
             * AA
             * 38783
             * LAVAL
             * LAVAL A ETE A LAVAL
             * ET LA MARINE VA VENIR A MALTE
             * L’utilisateur saisit une chaîne de caractères terminée par un point . (à contrôler).

             * Ecrivez l’algorithme et le programme permettant d’affirmer si cette phrase est ou non un palindrome.

             * Si la chaîne de caractères n’est composée que du caractère ‘.’, l’utilisateur est invité à recommencer.

             * L’algorithme doit prévoir les 3 cas suivants :

             * la phrase est vide
             * la chaîne de caractères n’est pas un palindrome
             * la chaîne de caractères est un palindrome */

            Console.WriteLine("Exercice 5.5 : Palindrome : ");

            // VARIABLES

            string stockageSaisie;
            string traitementSaisie;
            char[] palindrome;
            char[] palindromeInverse;
            bool palOk = true;

            // TRAITEMENT

            Console.WriteLine("Est-ce un palindrome ? ");
            stockageSaisie = Console.ReadLine();
            traitementSaisie = stockageSaisie.Replace(" ", "").ToLower();

            // créer et alimenter un tableau pour les donners utilisateurs

            palindrome = traitementSaisie.ToCharArray();

            // vérifier s'il y a un point.

            while (traitementSaisie.Length < 1 || !traitementSaisie.Contains("."))
            {
                Console.WriteLine("La phrase est vide ou ne se termine pas par un point.Veuillez recommencer.");
                stockageSaisie = Console.ReadLine();
                traitementSaisie = stockageSaisie.Replace(" ", "").ToLower();
            }

            // créer et alimenter un tableau verification avec le array.reverse

            palindromeInverse = traitementSaisie.ToCharArray();
            Array.Reverse(palindromeInverse);

            // vérifiez les égalités dans les tableaux

            for (int i = 0; i < palindrome.Length - 1; i++)
            {
                if (palindrome[i] == palindromeInverse[i + 1])
                {
                    palOk = true;
                }
                else
                {
                    palOk = false;
                    break;
                }
            }

            // AFFICHAGE

            if (palOk == true)
            {
                Console.WriteLine(stockageSaisie + " est un palindrome.");
            }
            else
            {
                Console.WriteLine(stockageSaisie + " n'est pas un palindrome.");
            }
        }
    }
}


