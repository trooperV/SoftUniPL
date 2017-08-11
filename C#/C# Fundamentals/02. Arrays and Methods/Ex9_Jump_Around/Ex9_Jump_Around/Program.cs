using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = arr[0];
            int index = 0;

            while (true)
            {
                if(!MoveRight(arr, ref sum, ref index))
                {
                    if(!MoveLeft(arr, ref sum, ref index))
                    {
                        Console.WriteLine(sum);
                        break;
                    }
                }
            }
        }

        static bool MoveRight(int[] arr, ref int sum, ref int index)
        {
            if (index + arr[index] > arr.Length)
            {
                return false;
            }

            sum += arr[index + arr[index]];
            index = index + arr[index];

            return true;
        }

        static bool MoveLeft(int[] arr, ref int sum, ref int index)
        {
            if (index - arr[index] < 0)
            {
                return false;
            }

            sum += arr[index - arr[index]];
            index = index - arr[index];

            return true;
        }
    }
}
