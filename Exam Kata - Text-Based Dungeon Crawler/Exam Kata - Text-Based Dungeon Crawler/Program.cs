namespace Exam_Kata___Text_Based_Dungeon_Crawler;

using System.Collections.Generic;

interface ISpeakable
{
    void Speak();
}

interface IDamageable
{
    void TakeDamage(int damage);
}

class Player : ISpeakable, IDamageable
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }

    public Player(string name)
    {
        Name = name;
        Health = 100;
        Level = 1;
        Experience = 0;
    }

    public void Attack(Enemy enemy)
    {
        int damage = 20; // Fixed damage for simplicity
        Console.WriteLine($"{Name} attacks {enemy.Type} for {damage} damage.");
        enemy.TakeDamage(damage);
    }

    public void Heal()
    {
        Health += 20;
        Console.WriteLine($"{Name} heals for 20 health. Current health: {Health}");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage. Health left: {Health}");
    }

    public void GainExperience(int exp)
    {
        Experience += exp;
        Console.WriteLine($"{Name} gains {exp} experience points.");
        if (Experience >= 100)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        Level++;
        Experience = 0;
        Console.WriteLine($"{Name} levels up! New level: {Level}");
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Ready for battle!");
    }
}

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
        Console.WriteLine($"{Name} says: Take a look at my wares.");
    }

    public void Trade()
    {
        Console.WriteLine("Available items for trade:");
        foreach (var item in Inventory)
        {
            Console.WriteLine(item);
        }
    }
}

class Game
{
    static Random random = new Random();

    public static void Main(string[] args)
    {
        
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();
        Player player = new Player(playerName);
        player.Speak();

        
        while (player.Health > 0)
        {
            
            int encounter = random.Next(1, 4); 

            if (encounter == 1) 
            {
                Enemy enemy = new Enemy("Goblin", 30, 5);
                Console.WriteLine($"\nA wild {enemy.Type} appears with {enemy.Health} health and {enemy.Damage} damage!");

                // Combat loop
                while (enemy.Health > 0 && player.Health > 0)
                {
                    Console.WriteLine("\nChoose an action:");
                    Console.WriteLine("1. Attack");
                    Console.WriteLine("2. Heal");
                    string action = Console.ReadLine();

                    if (action == "1")
                    {
                        player.Attack(enemy);
                        if (enemy.Health > 0)
                        {
                            int damage = random.Next(1, enemy.Damage + 1);
                            player.TakeDamage(damage);
                        }
                    }
                    else if (action == "2")
                    {
                        player.Heal();
                    }

                    if (player.Health <= 0)
                    {
                        Console.WriteLine("You have been defeated! Game Over.");
                        return;
                    }
                }

                if (enemy.Health <= 0)
                {
                    player.GainExperience(30);
                }
            }
            else if (encounter == 2) 
            {
                NPC npc = new NPC("Villager", "Welcome to our village!");
                npc.Speak();
            }
            else if (encounter == 3) 
            {
                Merchant merchant = new Merchant("Trader", new List<string> { "Sword", "Shield", "Potion" });
                merchant.Speak();
                merchant.Trade();
            }
        }
    }
}
