using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder reversedString = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString.Append(input[i]);
            }
            Console.WriteLine(reversedString);
        }
    }
}
