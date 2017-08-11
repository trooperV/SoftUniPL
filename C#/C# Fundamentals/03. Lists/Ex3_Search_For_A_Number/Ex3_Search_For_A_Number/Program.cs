using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Search_For_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> coms = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> nums2 = new List<int>();

            for (int i = 0; i < coms[0]; i++)
            {
                nums2.Add(nums[0]);
                nums.RemoveAt(0);
            }

            for (int i = 0; i < coms[1]; i++)
            {
                nums2.RemoveAt(0);
            }

            if (nums2.Remove(coms[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
