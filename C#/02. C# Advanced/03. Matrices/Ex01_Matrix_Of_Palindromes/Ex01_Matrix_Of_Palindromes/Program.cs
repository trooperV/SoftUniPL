using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Matrix_Of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rc = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int r = rc[0];
            int c = rc[1];

            string[,] matrix = new string[r,c];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = "" + (char)('a'+ i) + (char)('a'+(j+i)) + (char)('a' + i);
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
