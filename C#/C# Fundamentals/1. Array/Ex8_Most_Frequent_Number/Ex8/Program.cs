using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] n = Console.ReadLine().Split().Select(ushort.Parse).ToArray();

            int[] count = new int[ushort.MaxValue];

            foreach (ushort num in n)
            {
                count[num]++;
            }

            int maxValue = count.Max();

            for (int i = 0; i < n.Length; i++)
            {
                if (count[n[i]] == maxValue)
                {
                    Console.WriteLine(n[i]);
                    break;
                }
            }
            

            
        }
    }
}
