﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex10_Use_Your_Chains_Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

            string text = Console.ReadLine();
            string pattern = @"<p>(.*?(?=<))</p>";
            string patternRepl = @"[^a-z0-9]+";

            StringBuilder sb = new StringBuilder();
            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
            foreach (Match match in matches)
            {
                string tag = match.Groups[1].ToString();
                tag = Regex.Replace(tag, patternRepl, " ");
                char[] tagChars = tag.ToCharArray();
                for (int i = 0; i < tagChars.Length; i++)
                {
                    if (tagChars[i] >= 'a' && tagChars[i] <= 'm')
                    {
                        tagChars[i] = (char)(tagChars[i] + 13);
                    }
                    else if (tagChars[i] >= 'n' && tagChars[i] <= 'z')
                    {
                        tagChars[i] = (char)(tagChars[i] - 13);
                    }
                }
                sb.Append(new string(tagChars));
            }
            text = sb.ToString();
            text = Regex.Replace(text, patternRepl, " ");
            Console.WriteLine(text);
        }
    }
}
