using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex5_Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, @"(?<digit>\d+)(?<char>[A-Za-z])", RegexOptions.RightToLeft);

            StringBuilder sb = new StringBuilder(input);


            foreach (Match match in matches)
            {
                sb.Replace(match.Groups["digit"].ToString(), match.Groups["char"].ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
