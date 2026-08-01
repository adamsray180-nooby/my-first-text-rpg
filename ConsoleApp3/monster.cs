using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Monster
    {
        public string Name;
        public int Health;
        public int MinDamage;
        public int MaxDamage;
        public string Rarity;

        public Monster(string name, int health, int minDamage, int maxDamage, string rarity)
        {
            Name = name;
            Health = health;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Rarity = rarity;
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

