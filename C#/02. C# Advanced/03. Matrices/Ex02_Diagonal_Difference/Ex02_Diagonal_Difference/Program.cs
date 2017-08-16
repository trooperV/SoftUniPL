using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[n];
                arr[i] = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            int j = 0;
            int sum = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                sum += arr[j][i];
                j++;
            }

            j = 0;
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                sum2 += arr[j][i];
                j++;
            }

            Console.WriteLine(Math.Abs(sum - sum2));
        }
    }
}
