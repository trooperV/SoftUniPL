using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_A_Miners_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop") break;

                int quantity = int.Parse(Console.ReadLine());

                if (items.ContainsKey(resource))
                {
                    items[resource] += quantity;
                }
                else
                {
                    items[resource] = quantity;
                }
            }

            foreach (var item in items)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}