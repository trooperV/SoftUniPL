using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex3_Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string pattern = @"(?<str>[^\d]+)(?<num>[\d]+)";

            MatchCollection matches = Regex.Matches(input, pattern);

            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            foreach (Match item in matches)
            {
                for (int i = 0; i < int.Parse(item.Groups["num"].ToString()); i++)
                {
                    sb.Append(item.Groups["str"].ToString());
                }
            }

            sb2.Append(string.Join("", sb.ToString().Distinct()));

            Console.WriteLine("Unique symbols used: " + sb2.Length);
            Console.WriteLine(sb.ToString());
        }
    }
}
