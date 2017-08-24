using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex05_Extract_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)([a-zA-Z0-9]+)(_?|\.?|-?)([a-zA-Z0-9]+)*@[a-zA-Z]+\-?[a-zA-Z]+\.[a-zA-Z]+(\.[a-zA-Z]+)?";

            MatchCollection emails = Regex.Matches(Console.ReadLine(), pattern);

            foreach (Match email in emails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
