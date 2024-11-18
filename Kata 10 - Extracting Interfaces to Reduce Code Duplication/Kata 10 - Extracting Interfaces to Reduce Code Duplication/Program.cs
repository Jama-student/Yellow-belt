namespace Kata_10___Extracting_Interfaces_to_Reduce_Code_Duplication;

using System;
using System.Collections.Generic;

// Interface for classes that can speak
interface ISpeakable
{
    void Speak();
}

// Interface for classes that can take damage
interface IDamageable
{
    void TakeDamage(int damage);
}

// Player class implementing ISpeakable and IDamageable
class Player : ISpeakable, IDamageable
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

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Hello!");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage. Remaining health: {Health}");
    }
}

// Enemy class implementing IDamageable
class Enemy : IDamageable
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

// NPC class implementing ISpeakable
class NPC : ISpeakable
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

// Merchant class implementing ISpeakable
class Merchant : ISpeakable
{
    public string Name { get; set; }
    public List<string> Inventory { get; set; }

    public Merchant(string name, List<string> inventory)
    {
        Name = name;
        Inventory = inventory;
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Ready to trade!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances
        Player player = new Player("Arin", 100, 1);
        player.Attack("Goblin", 20);

        Enemy enemy = new Enemy("Goblin", 50, 10);
        enemy.TakeDamage(20);

        NPC npc = new NPC("Villager", "Welcome to our village!");
        npc.Speak();

        Merchant merchant = new Merchant("Trader", new List<string> { "Sword", "Shield", "Potion" });
        merchant.Speak();
    }
}