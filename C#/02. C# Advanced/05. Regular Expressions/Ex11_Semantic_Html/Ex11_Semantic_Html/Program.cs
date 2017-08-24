using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex11_Semantic_Html
{
    class Program
    {
        static void Main(string[] args)
        {
            //too hard for me
            StringBuilder semanticHTML = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") break;

                string patternOpeningTag = @"(?<indent>.*?)<div(?<attr1>.*?\s*?)(id|class)\s*?=\s*?""(?<tag>.*?)""(?<attr2>.*?\s*?)>";
                string pattenClosingTag = @"(?<indent>.*?)<\/div>\s*?<!--\s*?(?<tag>[^\s]*?)\s*?-->";

                if (Regex.IsMatch(input, patternOpeningTag))
                {
                    input = ConvertOpeningTagLine(input, patternOpeningTag);
                }
                if (Regex.IsMatch(input, pattenClosingTag))
                {
                    input = ConvertClosingTagLine(input, pattenClosingTag);
                }

                semanticHTML.AppendLine(input);
            }

            Console.WriteLine(semanticHTML.ToString());
        }

        private static string ConvertClosingTagLine(string htmlLine, string pattern)
        {
            Match match = Regex.Match(htmlLine, pattern);
            string[] validTags = new string[] { "main", "header", "nav", "article", "section", "aside", "footer" };

            if (!validTags.Contains(match.Groups["tag"].Value))
            {
                return htmlLine;
            }

            StringBuilder modifiedLine = new StringBuilder()
                    .Append(match.Groups["indent"])
                    .Append("</")
                    .Append(match.Groups["tag"])
                    .Append(">");

            return modifiedLine.ToString();
        }

        private static string ConvertOpeningTagLine(string htmlLine, string pattern)
        {
            Match match = Regex.Match(htmlLine, pattern);

            StringBuilder tag = new StringBuilder()
                    .Append(match.Groups["tag"])
                    .Append(" ")
                    .Append(match.Groups["attr1"])
                    .Append(" ")
                    .Append(match.Groups["attr2"]);
            string trimmedTag = Regex.Replace(tag.ToString(), @"\s+", " ")
                    .Trim();
            StringBuilder modifiedLine = new StringBuilder()
                    .Append(match.Groups["indent"])
                    .Append("<")
                    .Append(trimmedTag)
                    .Append(">");

            return modifiedLine.ToString();
        }
    }
}
