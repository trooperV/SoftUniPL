using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int left = 0;
            int right = 0;
            if(arr.Length == 1) { Console.WriteLine(0); return; }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    left += arr[j];
                }

                for (int j = i+1; j < arr.Length; j++)
                {
                    right += arr[j];
                }

                if(right == left)
                {
                    Console.WriteLine(i);
                    return;
                }

                left = 0;
                right = 0;
            }

            Console.WriteLine("no");
        }
    }
}
