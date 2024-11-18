namespace _2._Kata_5_Methods_and_Parameters;
using System;

class Program
{
    // Method to attack an enemy
    static void AttackEnemy(string enemyName, int damage)
    {
        Console.WriteLine($"Attacked {enemyName} and dealt {damage} damage!");
    }

    // Method to heal a player
    static void HealPlayer(string playerName, int healAmount)
    {
        Console.WriteLine($"Player {playerName} healed {healAmount} health points!");
    }

    static void Main(string[] args)
    {
        // Call the AttackEnemy method with example values
        AttackEnemy("Goblin", 20);

        // Call the HealPlayer method with example values
        HealPlayer("Arin", 15);
    }
}

