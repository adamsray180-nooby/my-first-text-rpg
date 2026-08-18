using ConsoleApp2;

namespace ConsoleApp3
{
    internal class Combat
    {
        public void StartCombat(Player player, Monster monster)
        {
            Console.WriteLine(monster.Introduction);

            while (player.IsAlive() && monster.IsAlive())
            {
                Console.WriteLine($"{player.name} HP: {player.health}");
                Console.WriteLine($"{monster.Name} HP: {monster.Health}");

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Use Potion");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    int playerDamage = player.GetAttackDamage();

                    Console.WriteLine($"You attack the {monster.Name}!");

                    monster.TakeDamage(playerDamage);

                    Console.WriteLine($"You dealt {playerDamage} damage!");
                    Console.WriteLine();
                }
                else if (choice == "2")
                {
                    if (player.Inventory.Count > 0)
                    {
                        Item potion = player.Inventory[0];

                        int oldHealth = player.health;

                        player.Heal(potion.HealAmount);

                        player.Inventory.Remove(potion);

                        Console.WriteLine($"You used a {potion.Name}!");
                        Console.WriteLine($"You healed for {potion.HealAmount} HP.");
                        Console.WriteLine($"HP: {oldHealth} -> {player.health}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("You dont have any potions!");
                        continue;
                    }
                 
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                    continue;
                }
               

                if (!monster.IsAlive())
                {
                    Console.WriteLine($"You defeated the {monster.Name}!");
                    Console.WriteLine();
                    break;
                }

                Console.WriteLine($"{monster.Name} attacks!");

                int monsterDamage = monster.GetAttackDamage();

                player.TakeDamage(monsterDamage);

                
                Console.WriteLine($"You took {monsterDamage} damage.");
                Console.WriteLine();
            }

            if (!player.IsAlive())
            {
                Console.WriteLine();
                Console.WriteLine("You have been defeated...");
                Console.WriteLine();
            }
        }
    }
}
