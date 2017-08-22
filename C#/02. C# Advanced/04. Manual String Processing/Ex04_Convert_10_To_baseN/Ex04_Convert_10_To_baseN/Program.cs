using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Ex04_Convert_10_To_baseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();

            BigInteger baseN = BigInteger.Parse(nums[0]);
            BigInteger num = BigInteger.Parse(nums[1]);

            Stack<BigInteger> final = new Stack<BigInteger>();

            while (num != 0)
            {
                final.Push(num % baseN);
                num /= baseN;
            }

            StringBuilder sb = new StringBuilder();
            while(final.Count != 0)
            {
                sb.Append(final.Pop());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
