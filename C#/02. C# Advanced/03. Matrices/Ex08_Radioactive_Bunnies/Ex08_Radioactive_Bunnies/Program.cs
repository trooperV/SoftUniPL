using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Radioactive_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int r = input[0];
            int c = input[1];
            int[,][] arr = new int[r, c][];
            int playerR = -1;
            int playerC = -1;

            
            for (int i = 0; i < r; i++)
            {
                char[] input2 = Console.ReadLine().ToCharArray();
                for (int j = 0; j < c; j++)
                {
                    arr[i, j] = new int[21];
                    if (input2[j] == '.') arr[i, j][0] = 0;
                    if (input2[j] == 'B') arr[i, j][0] = 1;
                    if (input2[j] == 'P')
                    {
                        arr[i, j][0] = 2;
                        playerR = i;
                        playerC = j;
                    }
                }
            }

            char[] com = Console.ReadLine().ToCharArray();

            int layer = 0;
            bool win = false;
            bool eaten = false;
            for (int i = 0; i < com.Length; i++)
            {
                switch (com[i])
                {
                    case 'L':
                        if (playerC - 1 < 0)
                        {
                            win = true;
                            break;
                        }
                        if (arr[playerR, playerC - 1][layer] == 1)
                        {
                            eaten = true;
                            playerC--;
                            break;
                        }
                        arr[playerR, playerC - 1][layer + 1] = arr[playerR, playerC][layer];
                        playerC--;
                        break;
                    case 'R':
                        if (playerC + 1 >= c)
                        {
                            win = true;
                            break;
                        }

                        if (arr[playerR, playerC + 1][layer] == 1)
                        {
                            eaten = true;
                            playerC++;
                            break;
                        }

                        arr[playerR, playerC + 1][layer + 1] = arr[playerR, playerC][layer];
                        playerC++;
                        break;
                    case 'U':
                        if (playerR - 1 < 0)
                        {
                            win = true;
                            break;
                        }

                        if (arr[playerR - 1, playerC][layer] == 1)
                        {
                            eaten = true;
                            playerR--;
                            break;
                        }

                        arr[playerR - 1, playerC][layer + 1] = arr[playerR, playerC][layer];
                        playerR--;
                        break;
                    case 'D':
                        if (playerR + 1 >= r)
                        {
                            win = true;
                            break;
                        }

                        if (arr[playerR + 1, playerC][layer] == 1)
                        {
                            eaten = true;
                            playerR++;
                            break;
                        }

                        arr[playerR + 1, playerC][layer + 1] = arr[playerR, playerC][layer];
                        playerR++;
                        break;
                }
                //Print(arr, r, c, layer);
                //Console.WriteLine();
                for (int x = 0; x < r; x++)
                {
                    for (int y = 0; y < c; y++)
                    {
                        if (arr[x, y][layer] == 1)
                        {
                            //if (arr[x, y][layer + 1] == 2) eaten = true;
                            arr[x, y][layer + 1] = 1;
                            
                            if (y + 1 < c)
                            {
                                if (arr[x, y + 1][layer + 1] == 2) eaten = true;
                                arr[x, y + 1][layer + 1] = 1;
                            }
                            if (y - 1 >= 0)
                            {
                                if (arr[x, y - 1][layer + 1] == 2) eaten = true;
                                arr[x, y - 1][layer + 1] = 1;
                            }
                            if (x + 1 < r)
                            {
                                if (arr[x + 1, y][layer + 1] == 2) eaten = true;
                                arr[x + 1, y][layer + 1] = 1;
                            }
                            if (x - 1 >= 0)
                            {
                                if (arr[x - 1, y][layer + 1] == 2) eaten = true;
                                arr[x - 1, y][layer + 1] = 1;
                            }
                        }
                    }
                }

                if (win) {
                    Print(arr, r, c, layer+1);
                    Console.WriteLine($"won: {playerR} {playerC}");
                    break;
                }
                if (eaten) {
                    Print(arr, r, c, layer+1);
                    Console.WriteLine($"dead: {playerR} {playerC}");
                    break;
                }

                layer++;
            }
        }

        static void Print(int[,][] arr, int r, int c, int layer)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (arr[i, j][layer] == 0) Console.Write(".");
                    if (arr[i, j][layer] == 1) Console.Write("B");
                    if (arr[i, j][layer] == 2) Console.Write("P");
                }
                Console.WriteLine();
            }
        }
    }
}

