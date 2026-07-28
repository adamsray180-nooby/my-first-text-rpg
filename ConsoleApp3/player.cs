using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Player
    {
        public string name;
        public int health;
        public int AttackDamage;

        public void CreatePlayer()
        {
            Console.WriteLine("Enter your player name");

            name = Console.ReadLine();

            health = 100;
            AttackDamage = 10;

            
        }
    }
}
