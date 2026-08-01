
using ConsoleApp3;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("        TEXT RPG");
            Console.WriteLine("==========================");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. View Stats");
            Console.WriteLine("3. Quit Game");
            Console.WriteLine("testing");

            Player myPlayer = new Player();
              
            Pathing Explore = new Pathing();

            string input = Console.ReadLine();

            if (input == "3")
            {
                string exitgame = "thank you for playing";

                await TypeWriterEffect(exitgame, 50);
                return;
            }

            switch (input)
            {
                case "1":
                    
                    myPlayer.CreatePlayer();

                    await TypeWriterEffect($"\nwelcome {myPlayer.name}\n", 30);

                    string message = "You wake up at the edge of a dark forest.\r\n\r\nYou see two narrow paths stretching before you.";

                    await TypeWriterEffect(message, 30);

                    Console.WriteLine();

                    while (myPlayer.health > 0)
                    {
                        Explore.Explore(myPlayer);                    
                    }
                    break;

                case "2":
                    Console.WriteLine("Stats coming soon");
                    break;
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