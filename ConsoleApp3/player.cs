using System;
using System.Collections.Generic;
using ConsoleApp3;

namespace ConsoleApp2
{
    internal class Player
    {
        public List<Item> Inventory {  get; set; } = new List<Item>();

        public string name;
        public int health;
        public int MinDamage;
        public int MaxDamage;

        private static Random rng = new Random();
        public void CreatePlayer()
        {
            Inventory.Clear();

            Console.WriteLine("Enter your player name");
            name = Console.ReadLine();

            health = 100;
            MinDamage = 5;
            MaxDamage = 10;
        }

        public int GetAttackDamage()
        {
            return rng.Next(MinDamage, MaxDamage + 1);
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
            if (health < 0)
                health = 0;
        }
        public bool IsAlive()
        {
            return health > 0;
        }
        public void Heal(int amount)
        {
            health += amount;

            if (health > 100)
            {
                health = 100;
            }
        }
    }
}
