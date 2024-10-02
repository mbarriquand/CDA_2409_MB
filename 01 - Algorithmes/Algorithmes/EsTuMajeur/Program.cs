
﻿namespace EsTuMajeur;
internal class Program
{
    static void Main(string[] args)
    {
        /* Lire un nombre A correspondant à un âge (en années).
        Afficher “Vous êtes majeur” ou “Vous êtes mineur” selon le cas.
        Pour un nombre négatif le message doit être “Vous n’êtes pas encore né”.
        La majorité est fixée à 18 ans. */


        // VARIABLE

        int age;

        // TRAITEMENT

        try
        {
            Console.WriteLine("Entrer votre âge :"); // demande à l'utilisateur
            age = int.Parse(Console.ReadLine()); // récupère l'information auprès de l'utilisateur

            // Vérification de l'âge

            if (age >= 18)
            {
                Console.WriteLine("Vous êtes majeur");
            }

            else if (age < 0)
            {
                Console.WriteLine("Vous n'êtes pas né");
            }

            else
            {
                Console.WriteLine("Vous êtes mineur");
            }
        }


        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }
    }

}
