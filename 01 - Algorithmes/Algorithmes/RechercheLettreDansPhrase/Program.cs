/* CONSIGNES
Soit une chaîne de caractères terminée par le caractère « . ».

Donnez l’algorithme d’un programme qui compte le nombre d’occurrences d’une lettre donnée (“a” par exemple) dans cette chaîne.

Si la chaîne de caractères est vide ou n’est composée que d’un caractère « . », le message “LA CHAINE EST VIDE” sera affiché.

Proposez un jeu d’essai prévoyant les 3 cas suivants :

La phrase est vide
La lettre n’est pas présente
La lettre est présente une ou plusieurs fois
*/

/* JEU D'ESSAI :
- " "
- "Barnabé fait ses courses." > on recherche la lettre 'z'
- "Barnabé fait ses courses chez Carrefour." > on recherche la lettre 'z'
*/

// VARIABLES

string saisieUtilisateur;
int occurence = 0;
char lettreRecherchee = ' ';


// TRAITEMENT

Console.WriteLine("Saisissez votre phrase");
saisieUtilisateur = Console.ReadLine();

char[] tableau = saisieUtilisateur.ToCharArray();

if (tableau.Length == 0)
{
    Console.WriteLine("LA CHAINE EST VIDE");
    System.Environment.Exit(1);
}

else
{
    Console.WriteLine("Quelle lettre recherchez vous ?");
    lettreRecherchee = char.Parse(Console.ReadLine());
}


for (int i = 0; i < tableau.Length; i++)
{ 
    if (tableau[i].Equals(lettreRecherchee))
    {
        occurence++;
        Console.WriteLine("La lettre recherchée " + lettreRecherchee + " apparait " + occurence + " fois dans la phrase.");
       // System.Environment.Exit(1);
    }
}

if (occurence == 0)
{
    Console.WriteLine("La lettre recherchée " + lettreRecherchee + " n'apparait pas dans la phrase");
}
