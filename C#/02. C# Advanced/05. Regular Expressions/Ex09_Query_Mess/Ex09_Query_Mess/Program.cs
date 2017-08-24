using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex09_Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "END") break;

                MatchCollection matches = Regex.Matches(inputLine, @"(?<field>[^&=?\s]*)=(?<value>[^&=\s]*)");

                Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();

                for (int i = 0; i < matches.Count; i++)
                {
                    string field = matches[i].Groups["field"].Value;
                    field = Regex.Replace(field, @"((%20|\+)+)", " ").Trim();

                    string value = matches[i].Groups["value"].Value;
                    value = Regex.Replace(value, @"((%20|\+)+)", " ").Trim();

                    if (!results.ContainsKey(field))
                    {
                        List<string> values = new List<string>();
                        values.Add(value);
                        results.Add(field, values);
                    }
                    else if (results.ContainsKey(field))
                    {
                        results[field].Add(value);
                    }
                }

                foreach (var pair in results)
                {
                    Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
                }
                Console.WriteLine();
            }
        }
    }
}
