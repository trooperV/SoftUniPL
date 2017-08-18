using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Target_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int r = input1[0];
            int c = input1[1];
            string str = Console.ReadLine();
            char[,] arr1 = FillStr(str, r, c);
            int[] input2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = input2[0];
            int col = input2[1];
            int radius = input2[2];
            int[,] arr2 = FillRadius(row, col, radius, r, c);
            //PrintC(arr1);
            //PrintN(arr2);
            //PrintC(FillFinal1(arr1, arr2));
            PrintC(FillFinal2(FillFinal1(arr1, arr2)));
        }

        static char[,] FillStr(string str, int r, int c)
        {
            char[,] arr = new char[r, c];
            List<char> l = str.ToCharArray().ToList();
            Queue<char> snake = new Queue<char>();
            l.ForEach(a => snake.Enqueue(a));
            int count = 0;
            for (int i = r - 1; i >= 0; i--)
            {
                if (count % 2 == 1)
                {
                    for (int j = 0; j < c; j++)
                    {
                        arr[i, j] = snake.Peek();
                        snake.Enqueue(snake.Dequeue());

                    }
                    count++;
                }
                else
                {
                    for (int j = c - 1; j >= 0; j--)
                    {
                        arr[i, j] = snake.Peek();
                        snake.Enqueue(snake.Dequeue());

                    }
                    count++;
                }
            }
            return arr;
        }

        static int[,] FillRadius(int row, int col, int radius, int r, int c)
        {
            int[,] arr = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if(Math.Pow(i - row, 2) + Math.Pow(j - col, 2) <= Math.Pow(radius, 2)){
                        arr[i, j] = 1;
                    }
                }
            }

            return arr;
        }

        static char[,] FillFinal1(char[,] arr1, int[,] arr2)
        {
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (arr2[i, j] == 1) arr1[i, j] = ' ';
                }
            }

            return arr1;
        }

        static char[,] FillFinal2(char[,] arr)
        {
            for (int i = arr.GetLength(0) - 2; i >= 0; i--)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int tempI = i;
                    while (true)
                    {
                        if(tempI + 1 < arr.GetLength(0) && arr[tempI, j] != ' ' && arr[tempI+1,j] == ' ')
                        {
                            arr[tempI+1, j] = arr[tempI, j];
                            arr[tempI, j] = ' ';
                            tempI++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return arr;
        }

        static void PrintC(char[,] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void PrintN(int[,] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
