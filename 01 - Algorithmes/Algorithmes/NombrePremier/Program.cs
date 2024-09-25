Console.WriteLine("Exercice 3a.5 : Nombre premier");

/* Lire un nombre N et déterminer s’il est un nombre premier.

Un nombre premier n’est divisible que par 1 et par lui-même. */

// VARIABLES

int N;
int check;
check = 0;

// TRAITEMENT

Console.WriteLine("Saisissez un nombre :");
N = int.Parse(Console.ReadLine());


for (int i = 1; i <= N; i++)
{
    if (N % i == 0)
    {
        check++;
    }
}

    if (check == 2)
    {
    Console.WriteLine(N + " est un nombre premier");
    }

    else
    {
        Console.WriteLine(N + " n'est pas un nombre premier");
    }

