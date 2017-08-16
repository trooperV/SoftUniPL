using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex13_Srabsko_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> places = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") break;

                var match = Regex.Match(input, @"(.+) @(.+) (\d+) (\d+)");
                if (match == null || match.Groups.Count != 5) continue;

                string singer = match.Groups[1].Value;
                string venue = match.Groups[2].Value;
                int ticketPrice = int.Parse(match.Groups[3].Value);
                int ticketsCount = int.Parse(match.Groups[4].Value);
                int money = ticketPrice * ticketsCount;

                if (!places.ContainsKey(venue)) places.Add(venue, new Dictionary<string, int>());
                if (!places[venue].ContainsKey(singer)) places[venue].Add(singer, 0);
                places[venue][singer] += money;
            }

            foreach (var place in places)
            {
                Console.WriteLine(place.Key);
                foreach (var singer in place.Value.OrderByDescending(money => money.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
