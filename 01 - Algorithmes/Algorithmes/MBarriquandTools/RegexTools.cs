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

        public static bool FormatPrenom(string _prenomAVerifier)
        {
            Regex rgxPrenom = new Regex(@"^([a-zA-Z\- ]{2,25})$");
            
            // string rgxPrenom;
            // rgxPrenom = @"^([a-zA-Z\- ]{2,25})$";

            return rgxPrenom.IsMatch(_prenomAVerifier);
        }               
    }
}