using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> arr = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] a = Console.ReadLine().Split();
                foreach (string item in a)
                {
                    arr.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
