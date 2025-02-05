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

        public Bouteille(float _contenanceMaxEnL,  float _contenuEnL, bool _estOuverte)
        {
            this.contenanceMaxEnL = _contenanceMaxEnL;
            this.contenuEnL = _contenuEnL;
            this.estOuverte = _estOuverte;
        }

        /* constructeur de clonage */

        public Bouteille(Bouteille _bouteilleACopier)
        {
            this.contenanceMaxEnL = _bouteilleACopier.contenanceMaxEnL;
            this.contenuEnL = _bouteilleACopier.contenuEnL;
            this.estOuverte = _bouteilleACopier.estOuverte;
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
