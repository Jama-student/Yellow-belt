namespace Mini_Kata_5_Simple_Methods
{
    using System;

    class Program
    {
        // Method for Attack
        static void Attack(int damage)
        {
            Console.WriteLine($"Player dealt {damage} damage!");
        }

        // Method for Heal
        static void Heal(int healAmount)
        {
            Console.WriteLine($"Player healed {healAmount} health points!");
        }

        static void Main(string[] args)
        {
            // Call the Attack method with a sample value
            Attack(15);

            // Call the Heal method with a sample value
            Heal(10);
        }
    }

}
