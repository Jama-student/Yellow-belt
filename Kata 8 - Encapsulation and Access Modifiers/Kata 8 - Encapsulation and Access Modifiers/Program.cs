namespace Kata_8___Encapsulation_and_Access_Modifiers;

using System;

class Player
{
    
    private int health;
    private int level;
    private int experience;

    
    public int Health
    {
        get { return health; } 
        private set 
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

    
    public Player(string name)
    {
        Name = name;
        health = 100;
        level = 1;
        experience = 0;
    }

    public string Name { get; set; }

    
    public void GainExperience(int exp)
    {
        Console.WriteLine($"Player gains {exp} experience points.");
        Experience += exp;

        if (Experience >= 100)
        {
            LevelUp();
        }
    }

    
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
        
        Player player = new Player("Arin");

    
        player.GainExperience(50); 
        player.GainExperience(60); 

    }
}
