using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, long>> pop = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('|');
                if (input[0] == "report") break;
                string country = input[1];
                string city = input[0];
                int population = int.Parse(input[2]);

                if (!pop.ContainsKey(country)) pop.Add(country, new Dictionary<string, long>());
                pop[country].Add(city, population);
                
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> country in pop.OrderByDescending(value => value.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (KeyValuePair<string, long> city in pop[country.Key].OrderByDescending(value => value.Value))
                {
                    if (city.Key == "total") continue;
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
