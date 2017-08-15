using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Reverse_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> num = new Stack<int>();
            List<int> nums = new List<int>();
            try
            {
                nums = Console.ReadLine().Split().Select(int.Parse).ToList();
                nums.ForEach(n => num.Push(n));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (num != null)
            {
                while (num.Count != 0)
                {
                    Console.Write(num.Pop() + " ");
                }
            }
        }
    }
}
