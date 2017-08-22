using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_Magic_Wxchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Console.WriteLine((TestWords(words[0], words[1])).ToString().ToLower());
        }

        static bool TestWords(string w1, string w2)
        {
            Dictionary<char, int> dict1 = FillDict(w2);
            Dictionary<char, int> dict2 = FillDict(w1);

            return dict1.Count() == dict2.Count();
        }

        static Dictionary<char, int> FillDict(string w)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in w.ToCharArray())
            {
                if (!dict.ContainsKey(c)) dict.Add(c, 0);
                dict[c]++;
            }

            return dict;
        }
    }
}
