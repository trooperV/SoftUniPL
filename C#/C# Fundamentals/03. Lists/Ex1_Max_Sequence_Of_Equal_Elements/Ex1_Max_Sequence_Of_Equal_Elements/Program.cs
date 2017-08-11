using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Max_Sequence_Of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int curS = 0;
            int curL = 1;
            int bestS = curS;
            int bestL = curL;

            for (int i = 1; i < nums.Count; i++)
            {
                if(nums[i] == nums[i - 1])
                {
                    curL++;
                }
                else
                {
                    curS = i;
                    curL = 1;
                }

                if (curL > bestL)
                {
                    bestL = curL;
                    bestS = curS;
                }
            }

            for (int i = bestS; i < bestS+bestL; i++)
            {
                Console.Write(nums[i]);
                if(i < bestS + bestL - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
