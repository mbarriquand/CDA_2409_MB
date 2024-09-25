Console.WriteLine("Exercice 3a.6 : Jeu de la fourchette :");

/*
L’ordinateur « choisit » aléatoirement un nombre mystère (entier compris entre 0 et 100).
Le joueur essaie de le deviner.
Lors de chaque essai, l’ordinateur affiche la « fourchette » dans laquelle se trouve le nombre qu’il a choisi.

Le choix du nombre mystère sera simulé par génération d’un nombre aléatoire : N <-- RANDOM(0,100).

Lorsque l’utilisateur a trouvé le nombre mystère, le programme affiche :

Bravo vous avez trouvé en X essais.
*/

// exercice non terminé

// VARIABLES

Random random = new Random(); 
int numRand = random.Next(0,100); // Génère un nombre random

int userGuess = 0;
int tries = 0;
int min = 1;
int max = 100;

// TRAITEMENT

while (userGuess != numRand)
{
    Console.WriteLine("Devinez le nombre mystère (entre 1 et 100) : ");
    userGuess = int.Parse(Console.ReadLine());

    if (userGuess > numRand)
    {
        Console.WriteLine("Le nombre mystère est plus petit");
    }

    else if (userGuess < numRand)
    {
        Console.WriteLine("Le nombre mystère est plus grand");
    }
        
    tries++;

}
Console.WriteLine("Bravo vous avez trouvé en " + tries + " essais");
