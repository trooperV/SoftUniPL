using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, int>> items = new Dictionary<string, Dictionary<double, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "stocked") break;

                string item = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!items.ContainsKey(item)) items.Add(item, new Dictionary<double, int>());
                if (!items[item].ContainsKey(price)) items[item].Add(price, 0);

                items[item][price] += quantity;
            }

            double total = 0;
            foreach (var i in items)
            {
                Console.WriteLine($"{i.Key}: ${i.Value.Last().Key:F2} * {i.Value.Values.Sum()} = ${i.Value.Last().Key * i.Value.Values.Sum():F2}");
                total += i.Value.Last().Key * i.Value.Values.Sum();
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${total:F2}");
        }
    }
}
