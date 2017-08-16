using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> people
                = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string ip = input[0];
                string user = input[1];
                int duration = int.Parse(input[2]);

                if (!people.ContainsKey(user)) people.Add(user, new SortedDictionary<string, int>());
                if (!people[user].ContainsKey(ip)) people[user][ip] = 0;
                people[user][ip] += duration;
            }

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key}: {person.Value.Values.Sum()} [{string.Join(", ", person.Value.Keys)}]");
            }
        }
    }
}
