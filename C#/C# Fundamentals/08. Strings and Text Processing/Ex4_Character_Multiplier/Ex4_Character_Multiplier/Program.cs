using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(Task(input[0], input[1]));
        }

        static int Task(string str1, string str2)
        {
            char[] str1C = str1.ToCharArray();
            char[] str2C = str2.ToCharArray();
            int ans = 0;
            int i = 0;
            for (i = 0; i < (str1.Length < str2.Length ? str1.Length : str2.Length); i++)
            {
                ans += str1C[i] * str2C[i];
            }

            int extraC = Math.Abs(str1.Length - str2.Length);
            for (int j = i; j < i + extraC; j++)
            {
                ans += (str1.Length < str2.Length ? str2 : str1)[j];
            }

            return ans;
        }
    }
}
