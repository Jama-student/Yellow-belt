namespace Kata_6_Array_and_lists;

using System.Collections.Generic; // Required for List

class Program
{
    static void Main(string[] args)
    {
        
        string[] enemies = { "Goblin", "Orc", "Troll", "Skeleton", "Dragon" };
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
        inventory.Add("Armor");

        
        inventory.Remove("Potion");

        
        Console.WriteLine("Updated Inventory:");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(); 

        // Step 6: Display the count of items in the inventory
        Console.WriteLine($"Total Items in Inventory: {inventory.Count}");
    }
}
