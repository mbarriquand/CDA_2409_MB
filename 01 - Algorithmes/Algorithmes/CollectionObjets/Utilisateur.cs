using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection.Objets
{
    public class Utilisateur
    {
        // private Guid id;
        
        private string nom;
        
        private string prenom;
       
        private DateTime dateDeNaissance;

        private string? metier;

        private string? couleur;

        public Utilisateur()
        {

        }

        public int GetAge()
        {
            throw new System.NotImplementedException();
        }

        public bool IsMajeur()
        {
            return false;
        }

        public string GetMetierOuCouleur()
        {
            return "";
        }
        public string GetDateDeNaissance()

        {
            return "";
        }

        public string GetNomComplet()
        {
            return prenom + " " + nom;
        }
    }
}