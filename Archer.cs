using System;

namespace Game_in_C
{
    public class Archer : Personnage
    {
        public Archer(string nom) : base(nom)
        {
            pointsDeVie = 105;
            degatsMin = 15;
            degatsMax = 20;
        }
    }
}
