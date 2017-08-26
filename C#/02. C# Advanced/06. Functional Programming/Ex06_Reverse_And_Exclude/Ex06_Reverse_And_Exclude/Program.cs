using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>> re = n => n.Reverse();
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int a = int.Parse(Console.ReadLine());
            re(nums);
            Predicate<int> dev = x => x % a != 0;
            foreach (int item in nums)
            {
                if (dev(item))
                {
                    Console.Write(item + " ");
                }
            }

            
        }
    }
}
