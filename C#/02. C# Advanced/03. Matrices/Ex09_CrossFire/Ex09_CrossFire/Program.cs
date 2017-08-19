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
            
            List<List<int>> arr = new List<List<int>>();

            int count = 1;
            for (int i = 0; i < rows; i++)
            {
                arr.Add(new List<int>());
                for (int j = 0; j < cols; j++)
                {
                    arr[i].Add(count++);
                }
            }

            //Print(arr);

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
                    if (i >= 0 && i < arr.Count && c >= 0 && c < arr[0].Count)
                    {
                        arr[i][c] = 0;
                    }
                }

                for (int i = c - radius; i <= c + radius; i++)
                {
                    if (i >= 0 && i < arr[0].Count && r >= 0 && r < arr.Count)
                    {
                        arr[r][i] = 0;
                    }
                }

                for (int i = 0; i < arr.Count; i++)
                {
                    for (int j = 0; j < arr[0].Count; j++)
                    {
                        int tempJ = j;
                        while (true)
                        {
                            if (tempJ - 1 >= 0 && arr[i][tempJ] != 0 && arr[i][tempJ - 1] == 0)
                            {
                                arr[i][tempJ - 1] = arr[i][tempJ];
                                arr[i][tempJ] = 0;
                                tempJ--;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                MarkEmpty(arr);
                //Print(arr);

            }

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[0].Count; j++)
                {
                    if (arr[i][j] == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(arr[i][j] + " ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void Print(List<List<int>> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[0].Count; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static void MarkEmpty(List<List<int>> target)
        {

            for (int r = 0; r < target.Count; r++)
            {
                // if a row contains only "Empty" elements it is removed
                if (target[r].All(x => x == 0))
                {
                    target.Remove(target[r]);
                    continue;
                }
            }
            for (int r = 0; r < target.Count; r++)
            {
                var nulls = target[r].Count(x => x == 0);
                if (nulls != 0)
                {
                    target[r] = target[r].Where(x => x != 0).ToList();
                    for (int i = 0; i < nulls; i++)
                    {
                        target[r].Add(0);
                    }
                }

            }
        }
    }
}
