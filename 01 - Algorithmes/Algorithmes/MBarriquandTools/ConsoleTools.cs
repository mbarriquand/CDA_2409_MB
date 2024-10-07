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
              
        public static string ComposantCBRegex(string _questionRegex)
        {
            string saisieUtilisateur;
            string RegexCB;
            bool saisieCBOk;

            RegexCB = (@"^[0-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{4}");

            do
            {
                Console.Write(_questionRegex);
                saisieUtilisateur = Console.ReadLine() ?? "";
               if (Regex.IsMatch(saisieUtilisateur, RegexCB))
                {
                    Console.WriteLine("Format valide");
                    saisieCBOk = true;
                }

               else if (!Regex.IsMatch(saisieUtilisateur, RegexCB))
                {
                    Console.WriteLine("Format invalide, recommencez !");
                    saisieCBOk = false;
                }

            }
            while (saisieUtilisateur != RegexCB);

            return RegexCB;
        }
    }
}
