using System;

namespace Game_in_C
{
    public  abstract class Entite
    {
        protected string nom;
        protected bool estMort = false;
        protected int pointsDeVie;
        protected int degatsMin;
        protected int degatsMax;
        protected Random random = new Random();

        public Entite(string nom)
        {
            this.nom = nom;
        }

        public void Attaquer(Entite uneEntite)
        {

        }
        protected void PerdrePointsDeVie(int pointsDeVie)
        {

        }

        public bool estMort()
        {
            return this.estMort;
        }


    }
}
