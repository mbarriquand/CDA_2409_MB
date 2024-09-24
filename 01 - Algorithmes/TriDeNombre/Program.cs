// Lire 3 nombres entier A, B et C (fournis par l'utilisateur) puis les afficher dans l’ordre croissant.

// Récupérer les données utilisateur

Console.WriteLine("Entrer le premier nombre:");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Entrer le deuxième nombre:");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine("Entrer le troisième nombre:");
int numC = int.Parse(Console.ReadLine());

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
