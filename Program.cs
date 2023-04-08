using System;

namespace Game_in_C
{
    pulic class Program : Personnage
    {
        public void Main(string[] args)
        {
            Menu();
        }

        static void Jouer(Personnage monPerso)
        {
            Monstre monstre =  new Monstre("Gobelin");
            bool victory = true;
            bool next = false;

            while(!monstre.estMort())
            {
                //tour monstre
                Console.ForegroundColor = ConsoleColor.Red;
                monstre.Attaquer(monPerso);
                Console.WriteLine();
                Console.ReadKey(true);
                
                if(monPerso.estMort())
                {
                    victory = false;
                    break; 
                }

                //tour perso 
                Console.ForegroundColor = ConsoleColor.Green;
                monPerso.Attaquer(monstre);
                Console.WriteLine();
                Console.ReadKey(true);
            }

            if(victory)
            {
                monPerso.gagnerExperience(5);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine(monPerso.Caracteristiques);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();

                while(!next)
                {
                    Console.WriteLine("Next room ? (Y/N)");
                    string a = Console.ReadLine().ToUpper();
                    if (a == "Y")
                    {
                        next = true;
                        Jouer(monPerso);
                    }
                    else if (a == "N")
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("You lost ...");
                Console.ReadKey();
            }
        }
        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The Game");
            Console.WriteLine();
            Console.WriteLine("Choose your class : ");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Wizard");
            Console.WriteLine("3. Archer");
            Console.WriteLine("4. Exit");
            Console.WriteLine();

            switch (Console.ReadLine())
            {
                case "1": 
                    Console.WriteLine("You chose a Warrior");
                    Console.WriteLine();
                    Jouer(new Guerrier("Audric"));
                    break;
                case "2": 
                    Console.WriteLine("You chose a Wizard");
                    Console.WriteLine();
                    Jouer(new Guerrier("Audric"));
                    break;
                case "3": 
                    Console.WriteLine("You chose an Archer");
                    Console.WriteLine();
                    Jouer(new Guerrier("Audric"));
                    break;

                case "4": 
                    break;
            }

        }
    }
}