using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex7_Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string[] com = Console.ReadLine().Split();
                char c = char.Parse(com[0]);
                int n = int.Parse(com[1]);

                Regex regex = new Regex($@"\{c}{{{n},}}");

                if (regex.IsMatch(input))
                {
                    MatchCollection matches = Regex.Matches(input, $@"\{c}{{{n},}}");

                    int index = matches[0].Index;
                    int length = matches[0].Length;

                    Console.WriteLine($"Hideout found at index {index} and it is with size {length}!");
                    break;
                }
            }
        }
    }
}
