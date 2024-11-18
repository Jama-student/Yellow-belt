namespace Kata_9___Object_Instantiation_with_Additional_Classes;

using System;
using System.Collections.Generic;

class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }

    public Player(string name, int health, int level)
    {
        Name = name;
        Health = health;
        Level = level;
    }

    public void Attack(string enemyName, int damage)
    {
        Console.WriteLine($"{Name} attacks {enemyName} and deals {damage} damage.");
    }
}

class Enemy
{
    public string Type { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public Enemy(string type, int health, int damage)
    {
        Type = type;
        Health = health;
        Damage = damage;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health > 0)
        {
            Console.WriteLine($"{Type} takes {damage} damage. Remaining health: {Health}");
        }
        else
        {
            Console.WriteLine($"{Type} is defeated!");
        }
    }
}

class NPC
{
    public string Name { get; set; }
    public string Dialogue { get; set; }

    public NPC(string name, string dialogue)
    {
        Name = name;
        Dialogue = dialogue;
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: {Dialogue}");
    }
}

class Merchant
{
    public string Name { get; set; }
    public List<string> Inventory { get; set; }

    public Merchant(string name, List<string> inventory)
    {
        Name = name;
        Inventory = inventory;
    }

    public void Trade()
    {
        Console.WriteLine($"{Name}'s inventory: {string.Join(", ", Inventory)}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Player instantiation and attack action
        Player player = new Player("Arin", 100, 1);
        player.Attack("Goblin", 20);

        // Enemy instantiation and taking damage
        Enemy enemy = new Enemy("Goblin", 50, 10);
        enemy.TakeDamage(20);

        // NPC instantiation and dialogue
        NPC npc = new NPC("Villager", "Welcome to our village!");
        npc.Speak();

        // Merchant instantiation and trading
        Merchant merchant = new Merchant("Trader", new List<string> { "Sword", "Shield", "Potion" });
        merchant.Trade();
    }
}