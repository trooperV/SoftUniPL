using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            long[] arr2 = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] arr3 = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            string name = Console.ReadLine();

            while(name != "done")
            {
                foreach (string el in arr1)
                {
                    if(el == name)
                    {
                        Console.WriteLine("{0} costs: {1}; Available quantity: {2}", name, arr3[Array.IndexOf(arr1, name)], arr2[Array.IndexOf(arr1, name)]);
                    }
                }

                name = Console.ReadLine();
            }
        }
    }
}
