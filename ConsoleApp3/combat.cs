using ConsoleApp2;

namespace ConsoleApp3
{
    internal class Combat
    {
        public void StartCombat(Player player, Monster monster)
        {
            Console.WriteLine($"{monster.Name} appeared!");

            while (player.health > 0 && monster.Health > 0)
            {
                Console.WriteLine($"{player.name} HP: {player.health}");
                Console.WriteLine($"{monster.Name} HP: {monster.Health}");

                Console.WriteLine("Press Enter to attack");
                Console.ReadLine();

                monster.Health -= player.AttackDamage;

                Console.WriteLine($"You dealt {player.AttackDamage} damage!");

                if (monster.Health <= 0)
                {
                    Console.WriteLine($"You defeated the {monster.Name}!");
                    break;
                }

                player.health -= monster.AttackDamage;

                Console.WriteLine($"{monster.Name} attacks!");
                Console.WriteLine($"You took {monster.AttackDamage} damage.");
            }

            if (player.health <= 0)
            {
                Console.WriteLine("You have been defeated...");
            }
        }
    }
}
