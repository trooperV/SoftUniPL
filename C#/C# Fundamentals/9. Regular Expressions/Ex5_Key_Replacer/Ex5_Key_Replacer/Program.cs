using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex5_Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string startEndPattern = @"(?<start>[A-Za-z]+)[\||\\|<][\w\\\|<]*[\|*|\\*|<*|\.*|>*|,*|:*](?<end>[A-Za-z]+)";

            Match input = Regex.Match(Console.ReadLine(), startEndPattern);

            if (input.Success)
            {
                string start = input.Groups["start"].ToString();
                string end = input.Groups["end"].ToString();
                string pattern = $"{start}(?<word>.*?){end}";
                MatchCollection matches = Regex.Matches(Console.ReadLine(), pattern);

                var result = new StringBuilder();

                foreach (Match match in matches)
                {
                    result.Append(match.Groups["word"].Value);
                }

                Console.WriteLine(result.ToString().Length == 0 ? "Empty result" : result.ToString());
            }
        }
    }
}
