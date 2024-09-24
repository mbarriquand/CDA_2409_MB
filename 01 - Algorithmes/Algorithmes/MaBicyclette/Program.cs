/* Réalisez l’algorithme et le programme correspondant au texte ci-dessous :

S’il fait beau demain, j’irai faire une balade à bicyclette.

Je n’ai pas utilisé ma bicyclette depuis plusieurs mois, peut-être n’est-elle plus en parfait état de fonctionnement.

Si c’est le cas, je passerai chez le garagiste avant la balade. J’espère que les réparations seront immédiates sinon je devrai renoncer à la balade en bicyclette. Comme je veux de toute façon profiter du beau temps, si mon vélo n’est pas utilisable, j’irai à pied jusqu’à l’étang pour cueillir les joncs.

S’il ne fait pas beau, je consacrerai ma journée à la lecture. J’aimerais relire le 1er tome de Game of Thrones. Je pense posséder ce livre, il doit être dans la bibliothèque du salon.

Si je ne le retrouve pas, j’irai l’emprunter à la bibliothèque municipale. Si le livre n’est pas disponible, j’emprunterai un roman policier.

Je rentrerai ensuite directement à la maison.

Dès que j’aurai le livre qui me convient, je m’installerai confortablement dans un fauteuil et je me plongerai dans la lecture.*/

// VARIABLES

bool beauTemps;
bool etatVeloOk;
bool repImmediates;
bool livreChezMoi;
bool livreDispoBibli;

// TRAITEMENT

Console.WriteLine("Exercice : ma bicyclette (réponse true/false)");

Console.WriteLine("Est-ce qu'il fait beau");
beauTemps = Convert.ToBoolean(Console.ReadLine());

if (beauTemps == true)
{
    Console.WriteLine("Est-ce que le vélo est en bon état ?");
    etatVeloOk = Convert.ToBoolean(Console.ReadLine());

    if (etatVeloOk == true)
    {
        Console.WriteLine("Je vais me ballader à bicyclette");
    }

    if (etatVeloOk == false)
    {
        Console.WriteLine("Est-ce que les réparations peuvent être faites immédiatement ?");
        repImmediates = Convert.ToBoolean(Console.ReadLine());


        if (repImmediates == true)
        {
            Console.WriteLine("Je vais me ballader à bicyclette");
        }

        else
        {
            Console.WriteLine("Je vais à pied jusqu'à l'étang pour cueillir des joncs.");
        }
    }
}


        if (beauTemps == false)
        {
            Console.WriteLine("Je vais passer la journée à lire.");

            Console.WriteLine("Est-ce que j'ai le premier tome de GoT ?");
            livreChezMoi = Convert.ToBoolean(Console.ReadLine());

            if (livreChezMoi == true)
            {
                Console.WriteLine("Je vais lire GoT.");
            }

            if (livreChezMoi == false)
            {
                Console.WriteLine("Je vais l'emprunter à la bibliothèque.");

                Console.WriteLine("Est-ce que GoT est disponible à la bibliothèque ?");
                livreDispoBibli = Convert.ToBoolean(Console.ReadLine());

                if (livreDispoBibli == true)
                {
                    Console.WriteLine("Je l'emprunte et je rentre le lire chez moi.");
                }
                else
                {
                    Console.WriteLine("J'emprunte un roman policier et je rentre le lire chez moi.");
                }
            }
        }