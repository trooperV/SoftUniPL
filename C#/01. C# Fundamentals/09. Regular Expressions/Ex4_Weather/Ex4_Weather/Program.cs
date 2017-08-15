using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex4_Weather
{
    class City
    {
        public string Name { get; set; }
        public float Temperature { get; set; }
        public string Weather { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<name>[A-Z]{2})(?<temperature>\d+\.\d+)(?<weather>[A-Za-z]+)\|";

            List<City> cities = new List<City>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;

                if (Regex.IsMatch(input, pattern))
                {
                    Match temp = Regex.Match(input, pattern);
                    City t = new City();
                    t.Name = temp.Groups["name"].Value;
                    t.Temperature = float.Parse(temp.Groups["temperature"].Value);
                    t.Weather = temp.Groups["weather"].Value;

                    if (cities.Any(a => a.Name == t.Name))
                    {
                        cities.First(a => a.Name == t.Name).Temperature = t.Temperature;
                        cities.First(a => a.Name == t.Name).Weather = t.Weather;
                    }
                    else
                    {
                        cities.Add(t);
                    }
                }
            }

            foreach (City city in cities.OrderBy(a => a.Temperature))
            {
                Console.WriteLine($"{city.Name} => {city.Temperature:f2} => {city.Weather}");
            }
        }
    }
}
