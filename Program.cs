using System;

class Character {
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public Character(string name, int health, int attack, int defense) {
        Name = name;
        Health = health;
        Attack = attack;
        Defense = defense;
    }

    public virtual void AttackTarget(Character target) {
        int damage = Attack - target.Defense;
        if (damage < 0) damage = 0;
        target.Health -= damage;
        Console.WriteLine(Name + " attaque " + target.Name + " et lui inflige " + damage + " degats !");
    }
}

class Warrior : Character {
    public Warrior(string name) : base(name, 100, 10, 5) {
    }

    public override void AttackTarget(Character target) {
        int damage = Attack + 5 - target.Defense;
        if (damage < 0) damage = 0;
        target.Health -= damage;
        Console.WriteLine(Name + " utilise son épée et inflige " + damage + " dégats au " + target.Name + " !");
    }
}

class Wizard : Character {
    public Wizard(string name) : base(name, 80, 15, 3) {
    }

    public override void AttackTarget(Character target) {
        int damage = Attack + 3 - target.Defense;
        if (damage < 0) damage = 0;
        target.Health -= damage;
        Console.WriteLine(Name + " lance un sort à " + target.Name + " et lui inflige  " + damage + " dégats !");
    }
}

class Archer : Character {
    public Archer(string name) : base(name, 90, 12, 4) {
    }

    public override void AttackTarget(Character target) {
        int damage = Attack + 4 - target.Defense;
        if (damage < 0) damage = 0;
        target.Health -= damage;
        Console.WriteLine(Name + " tire une flèche sur " + target.Name + " et lui inflige " + damage + " dégats !");
    }
}

class Monster : Character {
    public Monster() : base(" Monstre", 100, 10, 8) {
    }
}

class Game {
    public void Start() {
        Console.WriteLine("Bienvenue sur mon jeu!");
        Console.WriteLine("Choissisez votre presonnage : ");
        Console.WriteLine("1. Guerrier");
        Console.WriteLine("2. Sorcier");
        Console.WriteLine("3. Archer");

        Character player = null;
        int choice = int.Parse(Console.ReadLine());

        switch (choice) {
            case 1:
                Console.WriteLine("Entrez votre nom");
                player = new Warrior(Console.ReadLine());
                break;
            case 2:
                Console.WriteLine("Entrez votre nom");
                player = new Wizard(Console.ReadLine());
                break;
            case 3:
                Console.WriteLine("Entrez votre nom");
                player = new Archer(Console.ReadLine());
                break;
            default:
                Console.WriteLine("Mauvais choix, veuillez réessayer");
                return;
        }

        Monster monster = new Monster();

        while (player.Health > 0 && monster.Health > 0) {
            Console.WriteLine(player.Name + ": " + player.Health + " points de vie ");
            Console.WriteLine(monster.Name + ": " + monster.Health + " points de vie");
            Console.WriteLine();

            player.AttackTarget(monster);
            if (monster.Health > 0) {
                monster.AttackTarget(player);
            }
        }

        if (player.Health > 0)
        {
            Console.WriteLine("Vous avez gagné !");
        } else {
            Console.WriteLine("Vous avez perdu...");
        }
    }
    }
    class Program {
    static void Main(string[] args) {
        Game game = new Game();
        game.Start();
    }
}