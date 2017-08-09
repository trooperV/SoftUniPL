using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Ex1_Convert_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> digits = new List<BigInteger>();
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger n = input[0];
            BigInteger a = input[1];
            a *= n;
            while(a / n != 0)
            {
                a /= n;
                digits.Add(a % n);
            }
            digits.Reverse();
            Console.WriteLine(string.Join("", digits));
        }
    }
}
