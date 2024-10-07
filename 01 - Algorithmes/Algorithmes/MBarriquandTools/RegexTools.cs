using System.Numerics;
using System.Text.RegularExpressions;

namespace MBarriquandTools
{
    public class RegexTools
    {
        public static bool FormatCarteBancaire(string _numCbAVerifier)
        {
            string RegexCB;
            RegexCB = @"^([0-9]{4}[ -]?){3}[0-9]{4}$";

            return Regex.IsMatch(_numCbAVerifier, RegexCB);

        }

        public static bool FormatNom(string _nomAVerifier, int _longueurMinAcceptee = 30)
        {
            Regex rgxPrenom = new Regex(@"^([a-zA-Z\- ]{2,"+_longueurMinAcceptee+"})$");
            
            // string rgxPrenom;
            // rgxPrenom = @"^([a-zA-Z\- ]{2,25})$";

            return rgxPrenom.IsMatch(_nomAVerifier);
        }

        public static bool FormatMdp(string _mdpAVerifier)
        {
            

            bool mdpOk = true;

            string regexLettresMinuscules = @"[a-z]{1,}";
            string regexLettresMajuscules = @"[A-Z]{1,}";
            string regexChiffres = @"[0-9]{1,}";
            string regexCaracteresSpeciaux = @"[^a-zA-Z0-9]+";

            if (!Regex.IsMatch(_mdpAVerifier, regexLettresMinuscules) || 
                !Regex.IsMatch(_mdpAVerifier, regexLettresMajuscules) ||
                !Regex.IsMatch(_mdpAVerifier, regexChiffres) ||
                !Regex.IsMatch(_mdpAVerifier, regexCaracteresSpeciaux) ||
                _mdpAVerifier.Length <= 12
                )
            {
                mdpOk = false;
            }

            return mdpOk;
            
        }

        public static bool FormatMdp20Char(string _mdpAVerifier20)
        {
            // et on continue là
        }
    }
}