
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

            Monster goblin = new Monster();
                
                goblin.Name = "goblin";
                goblin.Health = 20;
                goblin.AttackDamage = 5;
                goblin.Rarity = "common";
              
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

                    await TypeWriterEffect($"\nwelcome {myPlayer.name}\n", 50);

                    string message = "You wake up at the edge of a dark forest.\r\n\r\nYou see two narrow paths stretching before you.";

                    string path = "Take left or right?";

                    await TypeWriterEffect(message, 50);

                    Console.WriteLine();

                    await TypeWriterEffect(path, 50);
                    Console.WriteLine();
                    Console.Write("> ");

                    string pathChoice = Explore.Explore();


                    if (pathChoice == "left")
                    {
                        Console.WriteLine("You encountered a goblin");

                        Combat battle = new Combat();
                        battle.StartCombat(myPlayer, goblin);
                    }
                    else if (pathChoice == "right")
                    {
                        Console.WriteLine("You continue walking...");
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