using System;

namespace ConsoleApp3
{
    internal class Monster
    {
        public string Name;
        public int Health;
        public int MinDamage;
        public int MaxDamage;
        public string Rarity;
        public string Introduction {  get; set; }
        
        //Constructor
        public Monster(string name, int health, int minDamage, int maxDamage, string rarity, string introduction)
        {
            Name = name;
            Health = health;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Rarity = rarity;
            Introduction = introduction;
        }
        
        private static Random rng = new Random();
        public int GetAttackDamage()
        {
            return rng.Next(MinDamage, MaxDamage + 1);
        }

        // Method to take damage
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }

        // Handy check
        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}

