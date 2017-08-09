using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;

            int[] arr1 = new int[k];
            int[] arr2 = new int[k];

            for (int i = 0; i < k; i++)
            {
                arr1[i] = arr[i];
            }
            Reverse(arr1);

            int x = 0;
            for (int j = arr.Length/2 + k; j < arr.Length; j++)
            {
                arr2[x] = arr[j];
                x++;
            }
            Reverse(arr2);

            int[] arr3 = new int[k * 2];
            int[] arr4 = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                arr3[i] = arr1[i];
            }

            int y = 0;
            for (int j = arr.Length / 2 - k; j < arr.Length / 2; j++)
            {
                arr3[j] = arr2[y];
                y++;
            }

            int z = 0;
            for (int i = k; i < arr.Length-k; i++)
            {
                arr4[z] = arr[i];
                z++;
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                arr4[i] += arr3[i];
            }



            Console.WriteLine(string.Join(" ", arr4));
        }

        static void Reverse(int[] arr)
        {
            for (int i = 0; i < arr.Length/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }
    }
}
