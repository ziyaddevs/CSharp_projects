using System;
using System.Collections.Generic;
using System.Linq;


namespace ThemePreview
{
    class Program
    {
        static void Main()
        {
            Hero hero = new("Batman", CharacterClass.Mage);

            hero.LevelUp();

            hero.AddItem(new Item("Iron Sword", 120));
            hero.AddItem(new Item("Magic Ring", 450));
            hero.AddItem(new Item("Potion", 30));
            hero.AddItem(new Item("Steel Shield", 200));
            hero.AddItem(new Item("Golden Amulet", 500));
            hero.AddItem(new Item("Leather Boots", 80));

            Console.WriteLine("Welcome to the Game!, please enjoy your stay! + Remember to have fun and be kind to others!");

            Utilities.PrintSeparator();

            int damage = hero.Attack();

            Console.WriteLine($"Damage dealt: {damage}");

            Utilities.PrintSeparator();

            List<int> numbers = Enumerable
                .Range(1, 20)
                .Where(x => x % 2 == 0)
                .Select(x => x * x)
                .ToList();

            Console.WriteLine("Squared Even Numbers:");

            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();

            Utilities.PrintSeparator();

            Dictionary<string, int> leaderboard = new()
            {
                ["Alice"] = 2400,
                ["Bob"] = 1850,
                ["Charlie"] = 3100,
                ["David"] = 1995,
                ["Emma"] = 4200
            };

            Console.WriteLine("Leaderboard");

            foreach (KeyValuePair<string, int> player in leaderboard.OrderByDescending(p => p.Value))
            {
                Console.WriteLine($"{player.Key,-10} {player.Value,6}");
            }

            Utilities.PrintSeparator();

            string rank = hero.Level switch
            {
                <= 5 => "Beginner",
                <= 10 => "Experienced",
                <= 20 => "Veteran",
                _ => "Legend"
            };

            Console.WriteLine($"Current Rank: {rank}");

            Utilities.PrintSeparator();

            try
            {
                int numerator = 100;
                int denominator = 5;

                Console.WriteLine($"{numerator} / {denominator} = {numerator / denominator}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Calculation complete.");
            }

            Utilities.PrintSeparator();

            Console.WriteLine("Inventory");

            foreach (Item item in hero.Inventory.OrderByDescending(i => i.Value))
            {
                Console.WriteLine($"{item.Name,-20} {item.Value,5} gold");
            }

            Utilities.PrintSeparator();

            double average =
                leaderboard
                    .Values
                    .Average();

            Console.WriteLine($"Average Score: {average:F2}");

            Utilities.PrintSeparator();

            int highest = Utilities.Max(44, 87);

            Console.WriteLine($"Highest Number: {highest}");

            Utilities.PrintSeparator();

            string[] languages =
            {
                "C#",
                "Python",
                "Java",
                "Go",
                "Rust",
                "JavaScript",
                "TypeScript"
            };

            Array.Sort(languages);

            foreach (string language in languages)
            {
                Console.WriteLine(language);
            }

            Utilities.PrintSeparator();

            Console.WriteLine("Finished!");
        }
    }
}