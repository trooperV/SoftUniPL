using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = n => n % 2 == 0;

            Dictionary<bool, List<int>> numbers = Console.ReadLine().Split().Select(int.Parse).GroupBy(n => isEven(n)).OrderByDescending(g => g.Key).ToDictionary(g => g.Key, g => g.OrderBy(n => n).ToList());

            foreach (KeyValuePair<bool, List<int>> group in numbers)
            {
                Console.Write(string.Join(" ", group.Value) + " ");
            }
        }
    }
}
