/* CONSIGNES
 * L’utilisateur est invité à saisir un mot de passe.
 * Si le mot de passe saisi est correct, le programme affiche “Vous êtes connecté”.
 * Dans le cas contraire, l’utilisateur doit recommencer la saisie.
 * L’utilisateur dispose de 3 essais maximum.
 * Au 3ème échec, le programme affiche “Votre compte est bloqué” et se termine.
 * Note : Le bon mot de passe est formation */

Console.WriteLine("Exercice 3a.2 : Contrôler la saisie avec limite");

// VARIABLES

const string BON_MOT_DE_PASSE = "formation";
const int ESSAIS_MAX = 3;

string saisieUtilisateur;

// TRAITEMENT

for (int i = 0; i < ESSAIS_MAX; i++)
{
    Console.WriteLine("Saisissez votre mot de passe :");
    saisieUtilisateur = Console.ReadLine();

    if (saisieUtilisateur == BON_MOT_DE_PASSE)
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


/* Autre possibilité avec une boucle while :
  
  const string BON_MOT_DE_PASSE = "formation";
  const int ESSAIS_MAX = 3;

  string saisieUtilisateur;
  int compteur = 1;
  
  Console.WriteLine("Saisissez votre mot de passe :");
        saisieUtilisateur = Console.ReadLine();
   
   while (!saisieUtilisateur.Equals(BON_MOT_DE_PASSE))
  {
      
      Console.WriteLine($"Mot de passe erroné {compteur}/{ESSAIS_MAX}");
       Console.WriteLine("Recommencez");
       saisieUtilisateur = Console.ReadLine();
       
       compteur++;
      
  }
    
   */