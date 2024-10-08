using System.Text.RegularExpressions;

namespace MBarriquandTools
{
    public class ConsoleTools
    {
        public static float DemanderFloatPositif(string _questionFloat)
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

        public static string DemanderMdP(string _questionMdP)
        {
            string saisieUtilisateur;
            bool saisieOk;

            do
            {
                Console.WriteLine(_questionMdP);

                saisieUtilisateur = Console.ReadLine() ?? " ";

                saisieOk = RegexTools.FormatMdp(saisieUtilisateur);

                if (!saisieOk);
                {
                    Console.WriteLine("Saisie invalide, recommencez !");
                }
            } while (!saisieOk);

            return saisieUtilisateur;

        }

        public static string DemanderMdP20char(string _questionMdP20Char)
        {
            string saisieUtilisateur;
            bool saisieOk;

            do
            {
                Console.WriteLine(_questionMdP20Char);

                saisieUtilisateur = Console.ReadLine() ?? " ";

                saisieOk = RegexTools.FormatMdp20Char(saisieUtilisateur);

                if (!saisieOk) ;
                {
                    Console.WriteLine("Saisie invalide, recommencez !");
                }
            } while (!saisieOk);

            return saisieUtilisateur;

        }

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

        public static string DemanderNumCarteBancaire(string _questionCB)
        {
            string saisieUtilisateur;
            bool saisieOk;

            do
            {
                Console.WriteLine(_questionCB);
                
                saisieUtilisateur = Console.ReadLine() ?? " ";

                saisieOk = RegexTools.FormatCarteBancaire(saisieUtilisateur);

                if (!saisieOk)
                {
                    Console.WriteLine("Saisie invalide, recommencez !");
                }

            } while (!saisieOk);

            return saisieUtilisateur;
        }

        public static string DemanderPrenomOuNom(string _questionNom)
        {
            string saisieUtilisateur;
            bool saisieOk;

            do
            {
                Console.WriteLine(_questionNom);

                saisieUtilisateur = Console.ReadLine() ?? " ";

                saisieOk = RegexTools.FormatNom(saisieUtilisateur);

                if (!saisieOk) ;
                {
                    Console.WriteLine("Saisie invalide, recommencez !");
                }
            } while (!saisieOk);

            return saisieUtilisateur;
        }
    }
}
