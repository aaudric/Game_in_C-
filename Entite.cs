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
            int degats = random.Next(degatsMin, degatsMax);
            uneEntite.PerdrePointsDeVie(degats);

            Console.WriteLine(this.nom + "(" + this.pointsDeVie + ") attacks : " + uneEntite.nom);
            Console.WriteLine(uneEntite.nom + " lost " + degats + "health points");
            Console.WriteLine(uneEntite.nom + " has " + uneEntite.pointsDeVie + "health points left");

            if(uneEntite.estMort())
            {
                Console.WriteLine(uneEntite.nom + "is dead");
            }
        }
        protected void PerdrePointsDeVie(int pointsDeVie)
        {
            this.pointsDeVie -= pointsDeVie;
            if(this.pointsDeVie <= 0)
            {
                this.pointsDeVie = 0;
                estMort = true;
            }
        }

        public bool estMort()
        {
            return this.estMort;
        }


    }
}
