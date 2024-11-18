namespace Mini_Kata_6_Array_and_List_Practice;

using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create and display the array of enemy names
        string[] enemies = { "Goblin", "Orc", "Troll" };
        Console.WriteLine("Enemies:");
        foreach (string enemy in enemies)
        {
            Console.WriteLine(enemy);
        }

        Console.WriteLine(); // Blank line for better formatting

        // Step 2: Create and display the list of player inventory items
        List<string> inventory = new List<string> { "Sword", "Shield", "Potion" };
        Console.WriteLine("Player Inventory:");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(); // Blank line for better formatting

        // Step 3: Add a new item to the inventory and display the updated list
        inventory.Add("Helmet");
        Console.WriteLine("Updated Inventory:");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }
    }
}