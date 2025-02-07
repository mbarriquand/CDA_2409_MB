using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            : this(_contenanceMaxEnL, _contenuEnL, false)
        {

        }

        /* constructeur de clonage */


         /* public Bouteille(Bouteille bouteilleACopier)
        {
            this.contenanceMaxEnL = bouteilleACopier.contenanceMaxEnL;
            this.contenuEnL = bouteilleACopier.contenuEnL;
            this.estOuverte = bouteilleACopier.estOuverte;
        } */

        public Bouteille(Bouteille bouteilleACopier)
            : this(bouteilleACopier.contenanceMaxEnL, bouteilleACopier.contenuEnL, bouteilleACopier.estOuverte)
        {

        }



        // METHODES


        public bool Ouvrir()
        {
            bool resultat;
            if (this.estOuverte == true)
            {
                resultat = false;
            }
            else
            {
                this.estOuverte = true;
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
                this.estOuverte = false;
                resultat = true;
            }

            return resultat;
        }

        public bool Remplir()
        {
            bool resultat;
            
            if(this.contenuEnL != this.contenanceMaxEnL && this.estOuverte == true)
            {
                resultat = true;
                this.contenuEnL = this.contenanceMaxEnL;
            }
            else
            {
                resultat = false;
            }

            return resultat;
        }

        public bool Vider()
        {
            bool resultat;
            if (this.contenuEnL == this.contenanceMaxEnL && !this.estOuverte)
            {
                resultat = true;
                this.contenuEnL = 0;
            }
            else
            {
                resultat = false;
            }

            return resultat;
        }

        public bool RemplirPartiellement(float quantiteEnL)
        {
            bool resultat;
            float espaceDispo = this.contenanceMaxEnL - this.contenuEnL;

            if (quantiteEnL < 0)
                throw new ArgumentOutOfRangeException("quantiteEnL", "La quantité ne peut pas être négative.");

            if (quantiteEnL <= espaceDispo && this.estOuverte == true && this.contenanceMaxEnL > 0f)
            {
                resultat = true;
                this.contenuEnL += quantiteEnL;
            }
            else
            {
                resultat = false;
            }

            return resultat;
        }

        public bool ViderPartiellement(float quantite)
        {
            bool resultat;
            float partiellementVide = this.contenanceMaxEnL - this.contenuEnL;

            if (quantite >= 0)
            {
                if (quantite >= partiellementVide && this.estOuverte == true && this.contenanceMaxEnL > 0f)
                {
                    resultat = true;
                    this.contenuEnL -= quantite;
                }
                else
                {
                    resultat = false;
                }
            }
            else
            {
                resultat = false;
            }
            return resultat;


        }
        
    }
}
