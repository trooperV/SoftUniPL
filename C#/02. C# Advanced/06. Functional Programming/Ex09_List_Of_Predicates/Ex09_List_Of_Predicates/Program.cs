using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            List<int> devs = Console.ReadLine().Split().Distinct().Select(int.Parse).ToList();
            List<int> devs2 = new List<int>();
            for (int i = 1; i <= a; i++)
            {
                bool isCool = true;

                foreach (int x in devs)
                {
                    Predicate<int> isDev = y => i % y != 0;

                    if (isDev(x))
                    {
                        isCool = false;
                        break;
                    }
                }

                if (isCool) devs2.Add(i);
            }

            Console.WriteLine(string.Join(" ", devs2));

        }
    }
}
