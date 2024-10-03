// Lire 3 nombres entier A, B et C (fournis par l'utilisateur) puis les afficher dans l’ordre croissant.

// il vaut mieux déclarer les variables séparement plutôt que de le faire à la volée
/*
int numA;
int numB;
int numC;
int[] nombres;
string saisieUtilisateur;

ex : saisieUtilisateur = Console.ReadLine(); // Récupération d'une saisie utilisateur
numA = int.Parse(saisieUtilisateur); // Conversion de la saisie en nombre entier
*/

// Récupérer les données utilisateur

using MBarriquandTools;

int numA;
int numB;
int numC;

numA = ConsoleTools.DemanderNombreEntier("Entrez le premier nombre: ");
numB = ConsoleTools.DemanderNombreEntier("Entrer le deuxième nombre: ");
numC = ConsoleTools.DemanderNombreEntier("Entrer le troisième nombre: ");

/*Console.WriteLine("Entrer le premier nombre:");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Entrer le deuxième nombre:");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine("Entrer le troisième nombre:");
int numC = int.Parse(Console.ReadLine());*/

// Générer un tableau pour stocker les données utilisateur

int[] nombres = {numA, numB, numC};

// Trier les données utilisateur

Array.Sort(nombres);

// Afficher les données utilisateur triées dans l'ordre croissant

Console.WriteLine("Vos nombres triés dans l'ordre croissant sont :");

    for (int i = 0; i < nombres.Length; i++)
    {
    Console.WriteLine(nombres[i]);
    } 
