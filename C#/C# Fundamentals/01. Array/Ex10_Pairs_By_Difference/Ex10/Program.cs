using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = i+1; j < n.Length; j++)
                {
                    if(Math.Abs(n[i] - n[j]) == num)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
