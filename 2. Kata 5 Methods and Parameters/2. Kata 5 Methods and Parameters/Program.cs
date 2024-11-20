namespace _2._Kata_5_Methods_and_Parameters;
using System;

class Program
{
    
    static void AttackEnemy(string enemyName, int damage)
    {
        Console.WriteLine($"Attacked {enemyName} and dealt {damage} damage!");
    }

    
    static void HealPlayer(string playerName, int healAmount)
    {
        Console.WriteLine($"Player {playerName} healed {healAmount} health points!");
    }

    static void Main(string[] args)
    {
        
        AttackEnemy("Goblin", 20);

        
        HealPlayer("Arin", 15);
    }
}

