using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split().Where(x => x.Length == 2).ToArray();

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                char[] charArray = nums[i].ToCharArray();
                Array.Reverse(charArray);
                Console.Write(Convert.ToChar(Convert.ToUInt32(new string(charArray), 16)));
            }
            Console.WriteLine();
        }
    }
}
