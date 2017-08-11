using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> names = new SortedDictionary<string, string>();

            bool running = true;

            while (running)
            {
                string[] com = Console.ReadLine().Split();

                switch (com[0])
                {
                    case "A":
                        names[com[1]] = com[2];
                        break;
                    case "S":
                        if (names.ContainsKey(com[1]))
                        {
                            Console.WriteLine("{0} -> {1}", com[1], names[com[1]]);
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", com[1]);
                        }
                        break;
                    case "ListAll":
                        foreach (var item in names)
                        {
                            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                        }
                        break;
                    case "END":
                        running = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
