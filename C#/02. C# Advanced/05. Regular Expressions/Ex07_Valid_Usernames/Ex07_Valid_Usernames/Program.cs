using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex07_Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> validUsernames =
                Regex.Split(Regex.Replace(Console.ReadLine(), @"\W+", " "), @"\s")
                        .Where(a => Regex.IsMatch(a, @"^[a-zA-Z][a-zA-Z0-9_]{2,24}$"))
                        .ToList();

            int sumMax = 0;
            string first = "";
            string second = "";

            for (int i = 1; i < validUsernames.Count; i++)
            {
                int currentSum = validUsernames[i - 1].Length + validUsernames[i].Length;
                if (currentSum > sumMax)
                {
                    sumMax = currentSum;
                    first = validUsernames[i - 1];
                    second = validUsernames[i];
                }
            }

            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
