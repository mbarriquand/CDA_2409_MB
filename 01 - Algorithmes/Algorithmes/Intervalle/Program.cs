// Lire 2 nombres entier A et B puis afficher tous les nombres entier dans l’intervalle.

Console.WriteLine("Exercice 3a.3 : Intervalle entre 2 nombres");

// VARIABLES

int A;
int B;

// TRAITEMENT

Console.WriteLine("Saisissez un nombre A :");
A = int.Parse(Console.ReadLine());

Console.WriteLine("Saisissez un nombre B :");
B = int.Parse(Console.ReadLine());

if (A < B)
{
    for (int i = A++; i < B; i++)
    {
        Console.WriteLine("Résultat = " + i + " ");
    }
}

else if (B < A)
{
    for (int i = A--; i > B; i--)
    {
        Console.WriteLine("Résultat = " + i + " ");
    }
}
