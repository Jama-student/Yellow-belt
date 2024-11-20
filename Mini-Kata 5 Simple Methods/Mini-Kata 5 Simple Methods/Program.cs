namespace Mini_Kata_5_Simple_Methods
{
    using System;

    class Program
    {
        
        static void Attack(int damage)
        {
            Console.WriteLine($"Player dealt {damage} damage!");
        }

        /
        static void Heal(int healAmount)
        {
            Console.WriteLine($"Player healed {healAmount} health points!");
        }

        static void Main(string[] args)
        {
            
            Attack(15);

            
            Heal(10);
        }
    }

}
