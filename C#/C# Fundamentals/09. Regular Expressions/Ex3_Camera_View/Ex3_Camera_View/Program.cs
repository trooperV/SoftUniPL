using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex3_Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int skip = input[0];
            int take = input[1];

            string[] elements = Regex.Matches(Console.ReadLine(),
                $@"(?<=\|<.{{{skip}}})[^|]{{0,{take}}}").Cast<Match>().Select(a => a.Value.ToString()).ToArray();

            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
