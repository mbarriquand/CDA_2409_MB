using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        // ATTRIBUTS 

        private float contenanceMaxEnL;
        private float contenuEnL;
        private bool estOuverte;

        // CONSTRUCTEURS

        /* constructeur par défaut */

        public Bouteille()
        {
            contenanceMaxEnL = 1.0f;
            contenuEnL = 1.0f;
            estOuverte = false;
        }

        /* constructeur classique */

        public Bouteille(float contenanceMaxEnL,
                        float contenuEnL,
                        bool estOuverte)
        {
            this.contenanceMaxEnL = contenanceMaxEnL;
            this.contenuEnL = contenuEnL;
            this.estOuverte = estOuverte;
        }

        /* alternative hybride entre le classique et le défaut */

        public Bouteille(float _contenanceMaxEnL,
                        float _contenuEnL)
        {
            contenanceMaxEnL = _contenanceMaxEnL;
            contenuEnL = _contenuEnL;
            this.estOuverte = false;
            
        }

        /* constructeur de clonage */


        public Bouteille(Bouteille bouteilleACopier)
        {
            this.contenanceMaxEnL = bouteilleACopier.contenanceMaxEnL;
            this.contenuEnL = bouteilleACopier.contenuEnL;
            this.estOuverte = bouteilleACopier.estOuverte;
        }


        // METHODES

        /* public bool Ouvrir()
        {
            bool resultat;
            if (this.estOuverte == true)
            {
                resultat = false;
            }
            else
            {
                this.estOuverte == true;
                resultat = true;
            }
            return resultat;
        }

        public bool Fermer()
        {
            bool resultat;
            if (this.estOuverte == false)
            {
                resultat = false;
            }
            else
            {
                this.estOuverte == false;
               resultat = true;
            }
            return resultat;
        }
        */

    }
}
