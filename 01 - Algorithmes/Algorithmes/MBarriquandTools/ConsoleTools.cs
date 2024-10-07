using System.Text.RegularExpressions;

namespace MBarriquandTools
{
    public class ConsoleTools
    {
        public static int DemanderNombreEntier(string _question)
        {
            string saisieUtilisateur;
            
            int valeurRetour;

            bool saisieOk;

            do
            {
                Console.WriteLine(_question);

                saisieUtilisateur = Console.ReadLine() ?? "";
                                
                /* valeurRetour = int.Parse(saisieUtilisateur);
                valeurRetour = Convert.ToInt32(saisieUtilisateur); // renvoie vers int.Parse mais effectue un contrôle
                                                                   // renvoie 0 si la valeur est nulle

                if(int.TryParse(saisieUtilisateur, out valeurRetour)) // si la conversion échoue, renvoie 'false'
                                                                      // si la conversion réussie, renvoie 'true' dans le out
                {

                } */

                saisieOk = int.TryParse(saisieUtilisateur, out valeurRetour);

                if(!saisieOk)
                {
                    Console.WriteLine("Saisie invalide, recommencez !");
                }

            } while (!saisieOk); 

            return valeurRetour;
        }

        public static float DemanderUnFloatPositif(string _questionFloat)
        {
            string saisieUtilisateur;

            float valeurRetour;

            bool saisieOk;

            do
            {
                Console.WriteLine(_questionFloat);
                
                saisieUtilisateur = Console.ReadLine() ?? "";

                saisieOk = float.TryParse(saisieUtilisateur,out valeurRetour) && valeurRetour >= 0;
                                
                if (!saisieOk)
                {
                        Console.WriteLine("Saisie invalide, recommencez !");
                }
                
            } while (!saisieOk);

            return valeurRetour;
        }

        public static string DemanderNumCarteBancaire(string _questionCB)
        {
            string saisieUtilisateur;
            bool saisieOk;

            do
            {
                Console.WriteLine(_questionCB);

                saisieUtilisateur = Console.ReadLine() ?? "";

                saisieOk = RegexTools.FormatCarteBancaire(saisieUtilisateur);

                if (!saisieOk)
                {
                    Console.WriteLine("Saisie invalide, recommencez !");
                }

            } while (!saisieOk);

            return saisieUtilisateur;
        }
    }
}
