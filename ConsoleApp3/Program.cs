
using ConsoleApp3;

namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Player myPlayer = new Player();
            Pathing Explore = new Pathing();

            while (true)
            {
                Console.WriteLine("==========================");
                Console.WriteLine("        TEXT RPG");
                Console.WriteLine("==========================");
                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. View Stats");
                Console.WriteLine("3. Quit Game");

                string input = Console.ReadLine();

                if (input == "3")
                {
                    await TypeWriterEffect("Thank you for playing!", 50);
                    return;
                }

                switch (input)
                {
                    case "1":

                        myPlayer.CreatePlayer();

                        Item potion = new Item("Health Potion", "Restore 25 health.", 25);
                        Item potion2 = new Item("Health Potion", "Restore 25 health.", 25);

                        myPlayer.Inventory.Add(potion);
                        myPlayer.Inventory.Add(potion2);

                        DisplayInventory(myPlayer);


                        await TypeWriterEffect($"\nwelcome {myPlayer.name}\n", 30);

                        string message = "You wake up at the edge of a dark forest.\r\n\r\nYou see two narrow paths stretching before you.";

                        await TypeWriterEffect(message, 30);

                        Console.WriteLine();

                        while (myPlayer.IsAlive())
                        {
                            Explore.Explore(myPlayer);
                        }

                        Console.WriteLine();
                        Console.WriteLine("========================");
                        Console.WriteLine("       GAME OVER");
                        Console.WriteLine("========================");
                        Console.WriteLine("Returning to main menu...");
                        Console.WriteLine();

                        break;

                    case "2":
                        Console.WriteLine("Stats coming soon");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please choose 1, 2, or 3.");
                        continue;
                }
            }
        }

        static void DisplayInventory(Player player)
        {
            Console.WriteLine($"Inventory count: {player.Inventory.Count}");
            Console.WriteLine("Inventory:");

            Dictionary<string, int> itemCount = new Dictionary<string, int>();

            foreach (Item item in player.Inventory)
            {
                if (itemCount.ContainsKey(item.Name))
                {
                    itemCount[item.Name]++;
                }
                else
                {
                    itemCount.Add(item.Name, 1);
                }
            }

            foreach (KeyValuePair<string, int> pair in itemCount)
            {
                Console.WriteLine($"{pair.Key} - x{pair.Value}");
            }
        }
        static async Task TypeWriterEffect(string message, int delayMs)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                await Task.Delay(delayMs);
            }
        }
    }
}