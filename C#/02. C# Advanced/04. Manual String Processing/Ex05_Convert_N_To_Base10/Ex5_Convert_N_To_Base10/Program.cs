using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Convert_N_To_Base10
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nums = Console.ReadLine().Split();

            BigInteger baseN = BigInteger.Parse(nums[0]);
            string num = nums[1];

            BigInteger answer = 0;
            int pow = 0;
            BigInteger realPow = 1;

            for (int i = num.Length-1; i >= 0; i--)
            {
                realPow = BigInteger.Pow(baseN, pow);
                answer += BigInteger.Parse(num[i].ToString()) * realPow;
                pow++;
            }

            Console.WriteLine(answer);
        }
    }
}
