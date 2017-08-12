using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex4_Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(new char[] { ',' , ' '}, StringSplitOptions.RemoveEmptyEntries);
            
            Regex regex = new Regex(@"(@{20}|#{20}|\${20}|\^{20})");
            Regex regex2 = new Regex(@"(?<seq>@{6,9}|#{6,9}|\^{6,9}|\${6,9})");

            foreach (string match in input)
            {
                if (match.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                if (regex.IsMatch(match))
                {
                    Console.WriteLine($"ticket \"{match}\" - 10{match[0]} Jackpot!");
                    continue;
                }

                string firstP = match.Substring(0, 10);
                string secondP = match.Substring(10, 10);

                if(regex2.IsMatch(firstP) && regex2.IsMatch(secondP))
                {
                    Match n1 = regex2.Match(firstP);
                    Match n2 = regex2.Match(secondP);

                    if (n1.Groups["seq"].ToString()[0] == n2.Groups["seq"].ToString()[0])
                    {
                        Console.WriteLine($"ticket \"{match}\" - {Math.Min(n1.Groups["seq"].Length, n2.Groups["seq"].Length)}{n1.Groups["seq"].ToString()[0]}");
                        continue;
                    }
                }

                Console.WriteLine($"ticket \"{match}\" - no match");
            }
        }
    }
}