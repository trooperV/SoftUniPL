using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ns = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[][] arr = new int[ns[0]][];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            int max = int.MinValue;
            int sum = 0;
            int winI = 0;
            int winJ = 0;

            for (int i = 2; i < ns[0]; i++)
            {
                for (int j = 2; j < ns[1]; j++)
                {
                    try
                    {
                        sum = arr[i][j] + arr[i][j - 1] + arr[i][j - 2] + arr[i - 1][j] + arr[i - 1][j - 1] + arr[i - 1][j - 2] + arr[i - 2][j] + arr[i - 2][j - 1] + arr[i - 2][j - 2];

                        if (sum > max) // this should be always '>'
                        {
                            max = sum;
                            winI = i - 2;
                            winJ = j - 2;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }

            Console.WriteLine("Sum = " + max);
            for (int i = winI; i < winI + 3; i++)
            {
                for (int j = winJ; j < winJ + 3; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
