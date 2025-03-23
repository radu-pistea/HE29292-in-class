using System;

namespace TerminalShooter
{
    class Player
    {
        public string Name = "";
        public int HP = 100;
        public int KillCount = 0;
        public int Damage = 25;
    }

    class Enemy
    {
        public int HP = 100;
        public int Damage = 10;
    }

    class Game
    {
        static Player player;
        static Enemy enemy;
        static Random rand = new Random();
        static int attackMultiplier = 1;

        static void DisplayStats()
        {
            Console.Clear();
            Console.WriteLine($"{player.Name}'s stats:\nHP: {player.HP}/100\nKill Count: {player.KillCount}\n\nEnemy HP: {enemy.HP}/100");
        }

        static void PlayerTurn()
        {
            int attackDice = rand.Next(1, 6);
            int defenseDice = rand.Next(1, 4);

            Console.Clear();
            Console.WriteLine($"\nAttack Dice: {attackDice}, Defender Dice: {defenseDice}");

            if (attackDice == defenseDice)
            {
                attackMultiplier++;
                Console.WriteLine($"Bonus multiplier increased! x{attackMultiplier}");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
            else if (attackDice < defenseDice)
            {
                Console.WriteLine("Attack missed!");
                attackMultiplier = 1;
                EnemyTurn();
            }
            else
            {
                int damage = attackMultiplier * (attackDice - defenseDice) * player.Damage;
                enemy.HP -= damage;
                Console.WriteLine($"Attack hit! {damage} dmg");
                attackMultiplier = 1;
                if (enemy.HP <= 0)
                {
                    player.KillCount++;
                    if (player.HP < 95)
                    {
                        player.HP += 5;
                    }
                    else
                    {
                        player.HP = 100;
                    }
                    Console.WriteLine("Enemy defeated! HP restored by 5");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    enemy = new Enemy();
                }
                else
                {
                    EnemyTurn();
                }
            }
        }

        static void EnemyTurn()
        {
            int attackDice = rand.Next(1, 6);
            int defenseDice = rand.Next(1, 5);

            Console.WriteLine($"\nEnemy Attack Dice: {attackDice}, Defender Dice: {defenseDice}");

            if (attackDice > defenseDice)
            {
                int damage = (attackDice - defenseDice) * enemy.Damage;
                player.HP -= damage;
                Console.WriteLine($"Enemy attack hit! {damage} dmg");
            }
            else
            {
                Console.WriteLine("Enemy attack missed!");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        static void Hide()
        {
            if (rand.Next(1, 101) <= 25)
            {
                Console.WriteLine("Successful stealth! Enemy attack missed!");
            }
            else
            {
                Console.WriteLine("You have been found!");
                EnemyTurn();
            }
        }

        static void Main()
        {
            Console.WriteLine("WELCOME TO TERMINAL SHOOTER");
            Console.Write("Enter your name: ");
            player = new Player { Name = Console.ReadLine() };
            enemy = new Enemy();
            
            while (player.HP > 0)
            {
                DisplayStats();
                Console.WriteLine("\n1. Attack\n2. Hide\n3. Quit\n");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    PlayerTurn();
                }
                else if (choice == "2")
                {
                    Hide();
                }
                else if (choice == "3")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("\nInvalid choice, try again.");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }

                /*switch (choice)
                {
                    case "1": PlayerTurn(); break;
                    case "2": Hide(); break;
                    case "3": return;
                    default: Console.WriteLine("Invalid choice, try again."); break;
                }*/
            }
            Console.Clear();
            Console.WriteLine("Game Over!");
        }
    }
}
