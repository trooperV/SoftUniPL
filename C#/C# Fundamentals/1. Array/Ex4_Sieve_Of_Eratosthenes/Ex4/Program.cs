using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n++;
            if (n != 1 && n != 0 && n != 2)
            {
                bool[] A = new bool[n];

                for (int i = 0; i < A.Length; i++)
                {
                    A[i] = true;
                }

                A[0] = false;
                A[1] = false;

                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if (A[i])
                    {
                        for (int j = i * i; j < n; j += i)
                        {
                            A[j] = false;
                        }
                    }
                }


                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] == true)
                    {
                        count++;
                    }
                }

                int[] arr = new int[count];

                int a = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] == true)
                    {
                        arr[a] = i;
                        a++;
                    }
                }

                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}