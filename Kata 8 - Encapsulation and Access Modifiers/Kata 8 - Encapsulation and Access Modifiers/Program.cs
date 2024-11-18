namespace Kata_8___Encapsulation_and_Access_Modifiers;

using System;

class Player
{
    // Private fields
    private int health;
    private int level;
    private int experience;

    // Public properties with encapsulation
    public int Health
    {
        get { return health; } // Allow external read access
        private set // Restrict modification to within the class
        {
            if (value >= 0)
                health = value;
        }
    }

    public int Level
    {
        get { return level; }
        set
        {
            if (value >= 0)
                level = value;
            else
                Console.WriteLine("Level cannot be negative.");
        }
    }

    public int Experience
    {
        get { return experience; }
        set
        {
            if (value >= 0)
                experience = value;
            else
                Console.WriteLine("Experience cannot be negative.");
        }
    }

    // Constructor to initialize default values
    public Player(string name)
    {
        Name = name;
        health = 100;
        level = 1;
        experience = 0;
    }

    public string Name { get; set; }

    // Method to gain experience and handle leveling up
    public void GainExperience(int exp)
    {
        Console.WriteLine($"Player gains {exp} experience points.");
        Experience += exp;

        if (Experience >= 100)
        {
            LevelUp();
        }
    }

    // Private method to handle leveling up
    private void LevelUp()
    {
        Level++;
        Experience = 0;
        Console.WriteLine($"Congratulations! You leveled up to Level {Level}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Player instance
        Player player = new Player("Arin");

        // Test gaining experience and leveling up
        player.GainExperience(50); // Should not level up
        player.GainExperience(60); // Should trigger level up

    }
}