using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Ex2_Base_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            BigInteger n = BigInteger.Parse(input[0]);
            List<char> digits = input[1].ToCharArray().ToList();
            BigInteger answer = 0;
            digits.Reverse();
            for (int i = 0; i < digits.Count; i++)
            {
                BigInteger dig = new BigInteger(char.GetNumericValue(digits[i]));
                answer += BigInteger.Multiply(dig, BigInteger.Pow(n, i));
            }

            Console.WriteLine(answer);
        }
    }
}
