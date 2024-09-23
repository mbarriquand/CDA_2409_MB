/* Lire un nombre A correspondant à un âge (en années).
Selon l’âge fourni, le programme doit afficher l’un des messages suivants :
Vous êtes à la retraite depuis X années
Il vous reste X années avant la retraite.
C’est le moment de prendre sa retraite.
La valeur fournie n’est pas un âge valide.
La retraite est fixée à 60 ans. */

// Lecture de la donnée utilisateur

Console.WriteLine("Entrez votre âge :");
int age = int.Parse(Console.ReadLine());

int retraite;
retraite = 60;

// Vérification de l'âge

    if (age > retraite)
    {
        Console.WriteLine("Vous êtes à la retraite depuis " + (age - retraite) + " ans.");
    }
    else if (age == retraite)
    {
        Console.WriteLine("C'est le moment de prendre sa retraite.");
    }
    else
    {
        Console.WriteLine("Il vous reste " + (retraite - age) + " années avant la retraite.");
    }