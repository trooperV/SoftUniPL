using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_CrossFire
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rc = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rc[0];
            int cols = rc[1];
            int count = 1;

            int[,] arr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = count;
                    count++;
                }
            }

            Print(arr);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Nuke it from orbit") break;
                int[] rcr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int r = rcr[0];
                int c = rcr[1];
                int radius = rcr[2];

                for (int i = r - radius; i <= r + radius; i++)
                {
                    if (i >= 0 && i < arr.GetLength(0) && c >= 0 && c < arr.GetLength(1))
                    {
                        arr[i, c] = -1;
                    }
                }

                for (int i = c - radius; i <= c + radius; i++)
                {
                    if (i >= 0 && i < arr.GetLength(1) && r >= 0 && r < arr.GetLength(0))
                    {
                        arr[r, i] = -1;
                    }
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 1; j < cols; j++)
                    {
                        int tempJ = j;
                        while (true)
                        {
                            if (tempJ - 1 >= 0 && arr[i, tempJ] != -1 && arr[i, tempJ - 1] == -1)
                            {
                                arr[i, tempJ - 1] = arr[i, tempJ];
                                arr[i, tempJ] = -1;
                                tempJ--;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                Print(arr);

            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (arr[i, j] == -1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
