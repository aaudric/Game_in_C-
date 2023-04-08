using System;

namespace Game_in_C
{
    public class Guerrier : Personnage
    {
        public Guerrier(string nom) : base(nom)
        {
            pointsDeVie = 120;
            degatsMin = 10;
            degatsMax = 15;
        } 
    }
}
