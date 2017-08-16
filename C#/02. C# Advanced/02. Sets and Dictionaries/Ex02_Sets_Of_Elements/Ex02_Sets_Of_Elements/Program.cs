using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Sets_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hashset1 = new HashSet<int>();
            HashSet<int> hashset2 = new HashSet<int>();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr[0]; i++)
            {
                hashset1.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < arr[1]; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if(hashset1.Contains(n)) hashset2.Add(n);
            }
            //hashset1.IntersectWith(hashset2);
            Console.WriteLine(string.Join(" ", hashset2));
        }
    }
}
