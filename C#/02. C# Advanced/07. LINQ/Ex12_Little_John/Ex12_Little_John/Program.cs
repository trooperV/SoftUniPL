using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex12_Little_John
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrowC();
        }

        static void ArrowC()
        {
            string[] arrows = new string[] { ">>>----->>", ">>----->", ">----->" };
            int[] arr = new int[3];
            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                for (int size = 0; size < arrows.Length; size++)
                {
                    arr[size] += Regex.Matches(input, arrows[size]).Count;
                    input = Regex.Replace(input, arrows[size], " ");
                }
            }
            EncB(int.Parse(string.Empty + arr[2] + arr[1] + arr[0]));
        }

        static void EncB(int num)
        {
            string binary = Convert.ToString(num, 2);
            StringBuilder sb = new StringBuilder();
            for (int i = binary.Length - 1; i >= 0; i--) sb.Append(binary[i]);
            binary += sb.ToString();
            Console.WriteLine(Convert.ToInt32(binary, 2));
        }
    }
}
