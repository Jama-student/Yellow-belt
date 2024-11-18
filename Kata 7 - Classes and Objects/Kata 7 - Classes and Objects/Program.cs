namespace Kata_7___Classes_and_Objects;

using System;

class Player
{
    // Properties for the Player class
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int Damage { get; set; }

    // Method to attack an enemy
    public void Attack(Enemy enemy)
    {
        Console.WriteLine($"Player {Name} attacks the {enemy.Type} and deals {Damage} damage.");
        enemy.TakeDamage(Damage);
    }

    // Method to gain experience
    public void GainExperience(int exp)
    {
        Experience += exp;
        Console.WriteLine($"Player {Name} gains {exp} experience points.");
    }
}

class Enemy
{
    // Properties for the Enemy class
    public string Type { get; set; }
    public int Health { get; set; }

    // Method to take damage
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health > 0)
        {
            Console.WriteLine($"{Type} takes {damage} damage. Remaining Health: {Health}");
        }
        else
        {
            Console.WriteLine($"{Type} takes {damage} damage and is defeated!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a Player instance and initialize properties
        Player player = new Player
        {
            Name = "Arin",
            Health = 100,
            Level = 1,
            Experience = 0,
            Damage = 20
        };

        // Step 2: Create an Enemy instance and initialize properties
        Enemy enemy = new Enemy
        {
            Type = "Orc",
            Health = 50
        };

        // Step 3: Simulate player attacking the enemy
        player.Attack(enemy);

        // Step 4: Simulate player gaining experience
        player.GainExperience(50);
    }
}