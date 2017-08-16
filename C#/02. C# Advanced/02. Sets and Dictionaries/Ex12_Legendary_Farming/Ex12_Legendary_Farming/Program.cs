using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> kMat = new Dictionary<string, int>();
            SortedDictionary<string, int> jMat = new SortedDictionary<string, int>();

            kMat.Add("shards", 0);
            kMat.Add("fragments", 0);
            kMat.Add("motes", 0);

            bool isRunning = true;
            while (isRunning)
            {
                string[] input = Console.ReadLine().ToLower().Split();
                for (int i = 0; i < input.Length; i += 2)
                {
                    string name = input[i + 1];
                    int quantity = int.Parse(input[i]);

                    if (name == "shards" || name == "fragments" || name == "motes")
                    {
                        kMat[name] += quantity;

                        if (kMat[name] >= 250)
                        {
                            kMat[name] -= 250;
                            switch (name)
                            {
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;
                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;
                            }

                            isRunning = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!jMat.ContainsKey(name)) jMat.Add(name, 0);
                        jMat[name] += quantity;
                    }
                }
            }

            foreach (KeyValuePair<string, int> item in kMat.OrderBy(key => key.Key).OrderByDescending(quantity => quantity.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (KeyValuePair<string, int> item in jMat.OrderBy(name => name.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
