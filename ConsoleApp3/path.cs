using ConsoleApp2;
using System;

namespace ConsoleApp3
{
    internal class Pathing
    {
        private static Random rng = new Random();

        public void Explore(Player player)
        {
            while (true)
            {
                Console.WriteLine("You come to a fork in the road.");
                Console.WriteLine();
                Console.WriteLine("Do you go left or right?");

                string choice = Console.ReadLine().ToLower();

                if (choice == "left" || choice == "right")
                {
                    Console.WriteLine($"You chose to go {choice}.");

                    RandomEncounter(player);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please choose left or right.");
                }
            }
        }

        private void RandomEncounter(Player player)
        {
            int encounterRoll = rng.Next(1, 101);

            if (encounterRoll <= 70)
            {
                Monster goblin = new Monster(
                    "Goblin",
                    20,
                    2,
                    5,
                    "Common",
                    "A goblin jumps out from the bushes!");

                Monster wolf = new Monster(
                    "Wolf",
                    30,
                    3,
                    7,
                    "Common",
                    "A hungry wolf blocks your path!");

                Monster skeleton = new Monster(
                    "Skeleton",
                    15,
                    1,
                    4,
                    "Common",
                    "A skeleton rises from the earth!");

                Monster[] monsters =
                {
                    goblin,
                    wolf,
                    skeleton
                };

                Monster selectedMonster = monsters[rng.Next(monsters.Length)];

                Combat combat = new Combat();
                combat.StartCombat(player, selectedMonster);
            }
            else
            {
                Console.WriteLine("The path is quiet....nothing happens.");
            }
        }
    }
}