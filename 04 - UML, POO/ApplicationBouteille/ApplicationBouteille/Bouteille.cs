namespace ApplicationBouteille
{
    internal class Bouteille
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

        /* constructeur personnalisé */

        public Bouteille(float contenanceMaxEnL,  float contenuEnL, bool estOuverte)
        {
            this.contenanceMaxEnL = contenanceMaxEnL;
            this.contenuEnL = contenuEnL;
            this.estOuverte = estOuverte;
        }

        /* constructeur de clonage */

        public Bouteille(Bouteille bouteilleACopier)
        {
            this.contenanceMaxEnL = bouteilleACopier.contenanceMaxEnL;
            this.contenuEnL = bouteilleACopier.contenuEnL;
            this.estOuverte = bouteilleACopier.estOuverte;
        }


        // METHODES

        public bool Ouvrir()
        {
            bool ouvrirOk;
            if (this.estOuverte == true)
            {
                ouvrirOk = false;
            }
            else
            {
                this.estOuverte = true;
                ouvrirOk = true;
            }
            return ouvrirOk;
        }

        public bool Fermer()
        {
            bool fermerOk;
            if (this.estOuverte == false)
            {
                fermerOk = false;
            }
            else
            {
                this.estOuverte = true;
                fermerOk = true;
            }
            return fermerOk;
        }


    }
}
