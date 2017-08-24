using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex08_Extract_Hyperlinks
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END") break;

                sb.AppendLine(input);
            }

            MatchCollection matches = Regex.Matches(sb.ToString(), @"(?:<a)(?:[\s\n_0-9a-zA-Z=""()]*?.*?)(?:href([\s\n]*)?=(?:['""\s\n]*)?)(?<word>([a-zA-Z:#\/._\-0-9!?=^+]*(\([""'a-zA-Z\s.()0-9]*\))?))(?:[\s\na-zA-Z=""()0-9]*.*?)?(?:\>)");

            foreach (Match item in matches)
            {
                if (item.Groups["word"].ToString() != "fake")
                {
                    Console.WriteLine(item.Groups["word"]);
                }
            }

        }
    }
}
