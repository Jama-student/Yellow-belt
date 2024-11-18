namespace Kata_6_Array_and_lists;

using System.Collections.Generic; // Required for List

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create and display the array of enemy names
        string[] enemies = { "Goblin", "Orc", "Troll", "Skeleton", "Dragon" };
        Console.WriteLine("Enemies:");
        foreach (string enemy in enemies)
        {
            Console.WriteLine(enemy);
        }

        Console.WriteLine(); // Blank line for better formatting

        // Step 2: Create and display the initial player inventory
        List<string> inventory = new List<string> { "Sword", "Shield", "Potion" };
        Console.WriteLine("Player Inventory:");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(); // Blank line for better formatting

        // Step 3: Add two new items to the inventory
        inventory.Add("Helmet");
        inventory.Add("Armor");

        // Step 4: Remove one item from the inventory
        inventory.Remove("Potion");

        // Step 5: Display the updated inventory
        Console.WriteLine("Updated Inventory:");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(); // Blank line for better formatting

        // Step 6: Display the count of items in the inventory
        Console.WriteLine($"Total Items in Inventory: {inventory.Count}");
    }
}
