using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex6_Sentence_Extractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            Regex regex = new Regex(@"(?=^|\s).*?[.?!]");

            MatchCollection sentences = regex.Matches(text);
            foreach (Match sentence in sentences)
            {
                Regex keyW = new Regex($@"\b{word}\b");
                if (keyW.IsMatch(sentence.Value))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
