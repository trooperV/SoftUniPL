using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Grab_And_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long n = long.Parse(Console.ReadLine());

            long index = 0;
            bool found = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if(n == arr[i])
                {
                    index = i;
                    found = true;
                }
            }

            long sum = 0;
            if (found)
            {
                for (int i = 0; i < index; i++)
                {
                    sum += arr[i];
                }

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
