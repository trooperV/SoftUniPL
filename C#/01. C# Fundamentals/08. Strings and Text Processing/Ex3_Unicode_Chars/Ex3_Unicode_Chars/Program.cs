using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Unicode_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                sb.Append(@"\u");
                sb.Append(string.Format($"{(int)c:x4}"));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
