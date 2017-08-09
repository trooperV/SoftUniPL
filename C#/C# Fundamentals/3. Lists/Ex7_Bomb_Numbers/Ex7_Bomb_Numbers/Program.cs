using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Sum(nums, bomb);

            Console.WriteLine(nums.Sum());
        }

        static void Sum(List<int> nums, int[] bomb)
        {
            for (int i = 0; i < nums.Count; i++)
            {

                if (nums[i] == bomb[0])
                {
                    int left = Math.Max(i - bomb[1], 0);
                    int right = Math.Min(i + bomb[1], nums.Count-1);

                    nums.RemoveRange(left, right- left + 1);
                    i = -1;
                }
                    
                
            }
        }
    }
}

