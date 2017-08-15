using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> n = new Stack<int>();

            List<int> nums2 = new List<int>();
            try
            {
                nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            for (int i = 0; i < nums[0]; i++)
            {
                try
                {
                    n.Push(nums2[i]);
                }catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            for (int i = 0; i < nums[1]; i++)
            {
                if(n.Count > 0)
                n.Pop();
            }

            if (n.Contains(nums[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                try
                {
                    Console.WriteLine(n.Min());
                }
                catch(Exception e)
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
