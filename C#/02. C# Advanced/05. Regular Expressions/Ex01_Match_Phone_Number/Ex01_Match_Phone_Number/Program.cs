using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex01_Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?=^| )\+359( |-)2\1\d{3}\1\d{4}\b");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;

                var matches = regex.Matches(input);
                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
