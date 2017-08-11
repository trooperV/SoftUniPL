using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            string[] arr2 = new string[10];
            int n = int.Parse(Console.ReadLine());
            int numIng = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (numIng >= 10) break;

                if (arr[i].Length == n)
                {
                    Console.WriteLine("Adding {0}.", arr[i]);
                    numIng++;

                    if (numIng <= 10)
                    {
                        arr2[numIng - 1] = arr[i];
                    }
                }
            }

            string[] arr3 = new string[numIng];

            for (int i = 0; i < numIng; i++)
            {
                arr3[i] = arr2[i];
            }

            if (numIng > 10) numIng = 10;

            Console.WriteLine("Made pizza with total of {0} ingredients.", numIng);
            Console.WriteLine("The ingredients are: {0}.", string.Join(", ", arr3));
        }
    }
}
