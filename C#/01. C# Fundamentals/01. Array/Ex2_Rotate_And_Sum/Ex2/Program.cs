using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrSum = new int[arr.Length];

            for (int j = 0; j < arrSum.Length; j++)
            {
                arrSum[j] = 0;
            }

            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                Rotate(arr);
                for (int l = 0; l < arrSum.Length; l++)
                {
                    arrSum[l] += arr[l];
                }
            }
            

            Console.WriteLine(string.Join(" ", arrSum));
        }

        static void Rotate(int[] arr)
        {
            int lastEl = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastEl;
        }
    }
}
