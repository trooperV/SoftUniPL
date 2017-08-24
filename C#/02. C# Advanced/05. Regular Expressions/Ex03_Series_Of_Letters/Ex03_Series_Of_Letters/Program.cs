using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex03_Series_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string answer = Regex.Replace(input, @"(\w)\1+", @"$1");

            Console.WriteLine(answer);
        }
    }
}
