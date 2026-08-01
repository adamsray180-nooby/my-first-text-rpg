using ConsoleApp2;

namespace ConsoleApp3
{
    internal class Combat
    {
        public void StartCombat(Player player, Monster monster)
        {
            Console.WriteLine($"{monster.Name} appeared!");

            while (player.IsAlive() && monster.IsAlive())
            {
                Console.WriteLine($"{player.name} HP: {player.health}");
                Console.WriteLine($"{monster.Name} HP: {monster.Health}");

                Console.WriteLine("Press Enter to attack");
                Console.ReadLine();

                int playerDamage = player.GetAttackDamage();

                monster.TakeDamage(playerDamage);

                Console.WriteLine($"You dealt {playerDamage} damage!");

                if (!monster.IsAlive())
                {
                    Console.WriteLine($"You defeated the {monster.Name}!");
                    break;
                }

                int monsterDamage = monster.GetAttackDamage();

                player.health -= monsterDamage;

                Console.WriteLine($"{monster.Name} attacks!");
                Console.WriteLine($"You took {monsterDamage} damage. ");
            }

            if (player.health <= 0)
            {
                Console.WriteLine("You have been defeated...");
            }
        }
    }
}
