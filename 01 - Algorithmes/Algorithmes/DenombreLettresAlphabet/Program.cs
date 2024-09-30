using System;

namespace DenombreLettresAlphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* CONSIGNES :
             * Lire un texte d’au moins 120 caractères (à contrôler).
             * Compter et afficher le nombre d’occurrences (d’apparitions) de chacune des lettres de l’alphabet.*/
            
          Console.WriteLine("Exercice 5.3 : Dénombrer les lettres de l’alphabet dans un tableau");

            // VARIABLES

            string phrase = " ";
            string[] alphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z".Split(' ').ToArray();
            int[] compteur = new int[alphabet.Length];

            // TRAITEMENT

            Console.WriteLine("Saisissez une phrase :");
            phrase = Console.ReadLine();
            phrase = phrase.ToLower();
            
            if (phrase.Length <= 120)
            {
                Console.WriteLine("Votre phrase doit faire plus de 120 caractères");
            }

            else
            {
                 foreach (char lettre in phrase)
                 {
                    // Trouver la position de "lettre" dans le tableau "alphabet"
                    int position = Array.IndexOf(alphabet, lettre.ToString());
                    // Incrémenter le 2eme tableau "compteur" à la même position
                    if(position > -1)
                    {
                        compteur[position]++;
                    }                                     
                 }

            // AFFICHAGE

                for (int position = 0; position < alphabet.Length; position++)
                {
                    // Afficher uniquement si la lettre apparaît au moins une fois
                    if (compteur[position] > 0) 
                    {
                        Console.WriteLine(alphabet[position] + ": " + compteur[position] + " occurences.");
                    }
                }

                Console.ReadLine();



            }
        }
    }
}
