Console.WriteLine("Exercice 3a.4 : Recherche des diviseurs d'un nombre");

// Lire un nombre entier et afficher tous ses diviseurs autres que 1 et lui-même.

// VARIABLES

int num;

// TRAITEMENT

Console.WriteLine("Saisissez un nombre :");
num = int.Parse(Console.ReadLine());

for (int i = 2; i < num; i++)
{  
        if ( num % i == 0 )
    {
        Console.WriteLine(num + " est divisible par " + i + " ");
    }
}