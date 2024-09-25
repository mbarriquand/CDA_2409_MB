/* L’utilisateur est invité à saisir un mot de passe.

Si le mot de passe saisi est correct, le programme affiche “Vous êtes connecté”.

Dans le cas contraire, l’utilisateur doit recommencer la saisie.

L’utilisateur dispose de 3 essais maximum.

Au 3ème échec, le programme affiche “Votre compte est bloqué” et se termine.

Note : Le bon mot de passe est formation */

// VARIABLES

string mdp;
string saisieUtilisateur;

// TRAITEMENT

mdp = "formation";

Console.WriteLine("Exercice 3a.2 : Contrôler la saisie avec limite");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Saisissez votre mot de passe :");
    saisieUtilisateur = Console.ReadLine();

    if (saisieUtilisateur == mdp)
    {
        Console.WriteLine("Vous êtes connecté");
        System.Environment.Exit(1);
    }

    else if (i == 3)
    {
        Console.WriteLine("Votre compte est bloqué");
    }

    else
    {
        Console.WriteLine("Mot de passe erroné");
    }
}
