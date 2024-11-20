namespace Mini_Kata_6_Array_and_List_Practice;

using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        
        string[] enemies = { "Goblin", "Orc", "Troll" };
        Console.WriteLine("Enemies:");
        foreach (string enemy in enemies)
        {
            Console.WriteLine(enemy);
        }

        Console.WriteLine(); 

        
        List<string> inventory = new List<string> { "Sword", "Shield", "Potion" };
        Console.WriteLine("Player Inventory:");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(); 

        
        inventory.Add("Helmet");
        Console.WriteLine("Updated Inventory:");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }
    }
}
