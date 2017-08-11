using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int defaultDamage = 45;
            int defaultHealth = 250;
            int defaultArmor = 10;

            Dictionary<string, SortedDictionary<string, int[]>> dragons = new Dictionary<string, SortedDictionary<string, int[]>>();
            int dragonsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < dragonsCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                string type = input[0];
                string name = input[1];
                int damage = input[2] == "null" ? defaultDamage : int.Parse(input[2]);
                int health = input[3] == "null" ? defaultHealth : int.Parse(input[3]);
                int armor = input[4] == "null" ? defaultArmor : int.Parse(input[4]);

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, int[]>();
                }
                dragons[type][name] = new[] { damage, health, armor };
            }

            foreach (var dragonType in dragons)
            {
                Console.WriteLine($"{dragonType.Key}::" +
                    $"({dragonType.Value.Select(x => x.Value[0]).Average():f2}" +
                    $"/{dragonType.Value.Select(x => x.Value[1]).Average():f2}" +
                    $"/{dragonType.Value.Select(x => x.Value[2]).Average():f2})");

                foreach (var dragon in dragonType.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
