using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = 0;
            int len = 1;
            int bestS = 0;
            int bestL = 1;

            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] >= n[i - 1]+1)
                {
                    len++;
                    if (len > bestL)
                    {
                        bestL = len;
                        bestS = start;
                    }
                }
                else
                {
                    start = i;
                    len = 1;
                }
            }
            

            for (int j = bestS; j < bestS + bestL; j++)
            {
                Console.Write(n[j] + " ");
            }
        }
    }
}
