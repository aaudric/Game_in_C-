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
        Console.WriteLine(Name + " attacks " + target.Name + " for " + damage + " damage!");
    }
}

class Warrior : Character {
    public Warrior(string name) : base(name, 100, 10, 5) {
    }

    public override void AttackTarget(Character target) {
        int damage = Attack + 5 - target.Defense;
        if (damage < 0) damage = 0;
        target.Health -= damage;
        Console.WriteLine(Name + " swings his sword and deals " + damage + " damage to " + target.Name + "!");
    }
}

class Wizard : Character {
    public Wizard(string name) : base(name, 80, 15, 3) {
    }

    public override void AttackTarget(Character target) {
        int damage = Attack + 3 - target.Defense;
        if (damage < 0) damage = 0;
        target.Health -= damage;
        Console.WriteLine(Name + " casts a spell on " + target.Name + " and deals " + damage + " damage!");
    }
}

class Archer : Character {
    public Archer(string name) : base(name, 90, 12, 4) {
    }

    public override void AttackTarget(Character target) {
        int damage = Attack + 4 - target.Defense;
        if (damage < 0) damage = 0;
        target.Health -= damage;
        Console.WriteLine(Name + " shoots an arrow at " + target.Name + " and deals " + damage + " damage!");
    }
}

class Monster : Character {
    public Monster() : base("Monster", 60, 10, 8) {
    }
}

class Game {
    public void Start() {
        Console.WriteLine("Welcome to the game!");
        Console.WriteLine("Choose your character:");
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Wizard");
        Console.WriteLine("3. Archer");

        Character player = null;
        int choice = int.Parse(Console.ReadLine());

        switch (choice) {
            case 1:
                player = new Warrior("Player");
                break;
            case 2:
                player = new Wizard("Player");
                break;
            case 3:
                player = new Archer("Player");
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                return;
        }

        Monster monster = new Monster();

        while (player.Health > 0 && monster.Health > 0) {
            Console.WriteLine(player.Name + ": " + player.Health + " HP");
            Console.WriteLine(monster.Name + ": " + monster.Health + " HP");
            Console.WriteLine();

            player.AttackTarget(monster);
            if (monster.Health > 0) {
                monster.AttackTarget(player);
            }
        }

        if (player.Health > 0)
        {
            Console.WriteLine("You win!");
        } else {
            Console.WriteLine("You lose...");
        }
    }
    }
    class Program {
    static void Main(string[] args) {
        Game game = new Game();
        game.Start();
    }
}