using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex04_Replace_A_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end") break;

                sb.AppendLine(input);
            }

            string pattern = @"<a(\s+href\s*=\s*.+?)>(.*?)<\/a>";
            string result = Regex.Replace(sb.ToString(), pattern, "[URL$1]$2[/URL]");

            Console.WriteLine(result);
        }
    }
}
