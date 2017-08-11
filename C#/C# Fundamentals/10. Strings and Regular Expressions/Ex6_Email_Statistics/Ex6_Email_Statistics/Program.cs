using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex6_Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<user>[A-Za-z]{5,})@(?<domain>[a-z]{3,}\.(com|bg|org))$";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> userDomain = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (regex.IsMatch(input))
                {
                    Match uderD = Regex.Match(input, pattern);
                    string username = uderD.Groups["user"].ToString();
                    string domain = uderD.Groups["domain"].ToString();

                    if (!userDomain.ContainsKey(domain))
                    {
                        userDomain[domain] = new List<string>();
                    }

                    if (!userDomain[domain].Contains(username))
                    {
                        userDomain[domain].Add(username);
                    }
                }
            }

            foreach (KeyValuePair<string, List<string>> domain in userDomain.OrderByDescending(a => a.Value.Count))
            {
                Console.WriteLine(domain.Key + ":");
                foreach (string user in domain.Value)
                {
                    Console.WriteLine("### " + user);
                }
            }
        }
    }
}
