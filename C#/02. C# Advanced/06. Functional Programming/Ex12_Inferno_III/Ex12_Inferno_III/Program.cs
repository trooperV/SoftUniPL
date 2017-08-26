using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_Inferno_III
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> gems = Console.ReadLine().Split().Select(int.Parse).ToList();

            HashSet<string> commands = new HashSet<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Forge") break;

                string[] tokens = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "Exclude":
                        commands.Add(tokens[1] + ";" + int.Parse(tokens[2])); break;
                    case "Reverse":
                        commands.Remove(tokens[1] + ";" + int.Parse(tokens[2])); break;
                    default: break;
                }
            }
            gems = FilterGems(gems, commands);
            Console.WriteLine(string.Join(" ", gems));
        }

        private static List<int> FilterGems(List<int> gems, HashSet<string> commands)
        {
            List<int> filteredGems = new List<int>();
            for (var i = 0; i < gems.Count; i++)
            {
                bool isExcluded = false;
                foreach (string command in commands)
                {
                    string[] tokens2 = command.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                    Dictionary<string, Func<int, int>> filters = new Dictionary<string, Func<int, int>>();
                    filters["Sum Left"] = x => gems[x] + (x == 0 ? 0 : gems[x - 1]);
                    filters["Sum Right"] = x => gems[x] + (x == gems.Count - 1 ? 0 : gems[x + 1]);
                    filters["SumLeftRight"] = x => filters["Sum Left"](x) + filters["Sum Right"](x) - gems[x];
                    Predicate<int> isMatch = x => x == int.Parse(tokens2[1]);

                    var sum = 0;
                    if (filters.ContainsKey(tokens2[0]))
                    {
                        sum = filters[tokens2[0]](i);
                    }

                    if (isMatch(sum))
                    {
                        isExcluded = true; break;
                    }
                }
                if (!isExcluded)
                {
                    filteredGems.Add(gems[i]);
                }
            }
            return filteredGems;
        }
    }
}