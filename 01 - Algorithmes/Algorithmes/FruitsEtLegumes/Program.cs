namespace FruitsEtLegumes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Exercice 6.1 : ");

            /* CONSIGNE :
             * L’utilisateur peut saisir des noms de légumes. Pour chaque légume, l’utilisateur précise un prix au kilo.
             * Exemple : “carottes 2.99” 
             * Lorsque l’utilisateur saisit la valeur “go”, le programme affiche la liste des légumes avec leur prix ainsi que le légume le moins cher.
             * 
             * Exemple :
             * 1 kilogramme de carottes coute 2.99 euros.  
             * 1 kilogramme de poireaux coute 1.99 euros.
             * [...]
             * Légume le moins cher au kilo : poireaux
             */

            // VARIABLES

            string saisieUtilisateur = " ";
            string[] fruitsEtLegumes = new string[100];
            double[] prix = new double[100];
            string[] split;

            // TRAITEMENT

            while (saisieUtilisateur != "go")
            {
                Console.WriteLine("Saisissez un fruit ou un légume et son prix au kilo :");
                saisieUtilisateur = Console.ReadLine();
            }

            split = saisieUtilisateur.Split(' ');

            for (int i = 0; i < fruitsEtLegumes.Length; i++)
            {
                fruitsEtLegumes[i] = split[0];
                prix[i] = double.Parse(split[1]);
            }

            Array.Sort(fruitsEtLegumes);
                       
            Console.WriteLine("Légume le moins cher au kilo : " + fruitsEtLegumes[0]);
            
            }
        }
    }

