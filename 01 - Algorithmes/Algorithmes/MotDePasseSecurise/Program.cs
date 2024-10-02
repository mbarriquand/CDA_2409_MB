using System.Text.RegularExpressions;

namespace MotDePasseSecurise
{
    /*
     L'utilisateur entre un mot de passe
    Le programme contrôle si le mot de passe respecte les règles en vigueur
    - 12 caractères minimum
    - ET au moins 1 minuscule
    - ET au moins 1 majuscule
    - ET au moins un chiffre
    - ET au moins un caractère spécial
    OU
    - 20 caractères minimum
    - ET au moins 1 minuscule
    - ET au moins 1 majuscule
    - ET au moins un chiffre
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string motDePasse;
            string regexLettresMinuscules;
            string regexLettresMajuscules;
            string regexChiffres;
            string regexCaracteresSpeciaux;


            Console.WriteLine("Saisissez un mot de passe :");

            motDePasse = Console.ReadLine() ?? "";

            regexLettresMinuscules = @"[a-z]{1,}"; // minimum 1, pas de maximum
                                                  // ou regexLettresMinuscules = @"[a-z]+"; ---------> un ou plusieurs

            regexLettresMajuscules = @"[A-Z]{1,}";

            regexChiffres = @"[0-9]{1,}";

            regexCaracteresSpeciaux = @"[^a-zA-Z0-9]+"; // ------> doit contenir un caractère qui n'est ni une majuscule, ni une minuscule, ni un chiffre

            if (
                Regex.IsMatch(motDePasse, regexLettresMinuscules) &&
                Regex.IsMatch(motDePasse, regexLettresMajuscules) &&
                Regex.IsMatch(motDePasse, regexChiffres) && 
                (Regex.IsMatch(motDePasse, regexCaracteresSpeciaux) || motDePasse.Length > 20) && motDePasse.Length >= 12
                )
            {
                Console.WriteLine("Mot de passe OK");
            }
            else
            {
                Console.WriteLine("Mot de passe faible");
            }
        }
    }
}
