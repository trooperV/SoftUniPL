using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] len = new int[nums.Count];
            int[] prev = new int[nums.Count];

            int bestL = 1;
            int bestS = 0;

            for (int p = 0; p < nums.Count; p++)
            {
                len[p] = 1;
                prev[p] = -1;

                for (int i = 0; i < p; i++)
                {
                    if (nums[p] > nums[i] && p != 0 && len[i] + 1 > len[p])
                    {
                        len[p] = len[i] + 1;
                        prev[p] = i;
                    }

                    if (len[p] > bestL)
                    {
                        bestL = len[p];
                        bestS = p;
                    }
                }
            }

            List<int> nums2 = new List<int>();

            for (int i = 0; i < bestL; i++)
            {
                nums2.Add(nums[bestS]);
                bestS = prev[bestS];
            }

            nums2.Reverse();

            Console.WriteLine(string.Join(" ", nums2));

        }
    }
}
