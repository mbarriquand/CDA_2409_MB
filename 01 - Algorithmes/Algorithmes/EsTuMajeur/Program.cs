namespace EsTuMajeur;
internal class Program
{
static void Main(string[] args)
{ 
/* Lire un nombre A correspondant à un âge (en années).
Afficher “Vous êtes majeur” ou “Vous êtes mineur” selon le cas.
Pour un nombre négatif le message doit être “Vous n’êtes pas encore né”.
La majorité est fixée à 18 ans. */

// lecture de la donnée utilisateur

Console.WriteLine("Entrer votre âge :");
int age = int.Parse(Console.ReadLine());

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
}
