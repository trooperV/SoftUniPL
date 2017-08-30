using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_Office_Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, long>> comp = new SortedDictionary<string, Dictionary<string, long>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Trim('|').Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                if (!comp.ContainsKey(input[0])) comp[input[0]] = new Dictionary<string, long>();
                if (!comp[input[0]].ContainsKey(input[2])) comp[input[0]][input[2]] = 0;
                comp[input[0]][input[2]] += long.Parse(input[1]);
            }

            foreach (var c in comp)
            {
                Console.WriteLine($"{c.Key}: {string.Join(", ", c.Value.Select(p => p.Key + "-" + p.Value))}");
            }
        }
    }
}
