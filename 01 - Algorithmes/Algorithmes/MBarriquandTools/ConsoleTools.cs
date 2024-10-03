namespace MBarriquandTools
{
    public class ConsoleTools
    {
        public static int DemanderNombreEntier(string _question)
        {
            string saisieUtilisateur;
            
            int valeurRetour;

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

            } while (!int.TryParse(saisieUtilisateur, out valeurRetour)); // on recommence la conversion tant que la condition est fausse

            return valeurRetour;
        }
    }
}
