using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex2_Extract_Sentences_By_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] input = Regex.Split(Console.ReadLine(),
                @"[!.?]").Select(a => a.TrimStart()).ToArray();

            foreach (string item in input)
            {
                if(Regex.IsMatch(item, $@"[^.!?;]*(({word}\W)|(\W{word}\W))"))
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}
