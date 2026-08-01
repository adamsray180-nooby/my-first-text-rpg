using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp3
{
    internal class Pathing
    {
        private static Random rng = new Random();

        public void Explore(Player player)
        {
            Console.WriteLine("You come to a fork in the road");
            Console.WriteLine("Do you go left or right");

            string choice = Console.ReadLine().ToLower();

            if (choice == "left" || choice == "right")
            {
                Console.WriteLine($"You chose to go {choice}. ");

                RandomEncounter(player);
            }
            else
            {
                Console.WriteLine("You must choose left or right");
            }

        }
        private void RandomEncounter(Player player)
        {
            int encounterRoll = rng.Next(1, 101);

            if (encounterRoll < 50)
            {
                Console.WriteLine("A monster appears!");

                Monster goblin = new Monster("Goblin", 20, 2, 5, "Common");

                Combat combat = new Combat();
                combat.StartCombat(player, goblin);
            }
            else
            {
                Console.WriteLine("The path is quiet....nothing happens.");
            }

        }



    }
}