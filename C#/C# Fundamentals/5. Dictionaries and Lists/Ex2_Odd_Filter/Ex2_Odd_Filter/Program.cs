using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> input2 = new List<int>();
            foreach (int i in input)
            {
                if (i % 2 == 0) input2.Add(i);
            }

            for (int i = 0; i < input2.Count; i++)
            {
                if (input2[i] > input2.Average()) input2[i]++;

                if (input2[i] < input2.Average()) input2[i]--;
            }

            Console.WriteLine(string.Join(" ", input2));
        }
    }
}
