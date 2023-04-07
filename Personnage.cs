using System;

namespace Game_in_C
{
    public abstract class Personnage : Entite
    {
        private int niveau;
        private int experience;

        public Personnage(string nom)
        {
            this.nom = nom;
            niveau = 1;
            experience = 0;
        }
    }
}
