using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Squares_In_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ns = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[][] arr = new char[ns[0]][];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }

            int count = 0;

            for (int i = 1; i < ns[0]; i++)
            {
                for (int j = 1; j < ns[1]; j++)
                {
                    if(arr[i][j] == arr[i][j-1] && arr[i-1][j] == arr[i - 1][j - 1] && arr[i-1][j] == arr[i][j])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
