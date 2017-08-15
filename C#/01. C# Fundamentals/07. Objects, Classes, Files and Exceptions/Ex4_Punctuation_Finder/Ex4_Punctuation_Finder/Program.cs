using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Punctuation_Finder
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<string> lines = File.ReadAllLines("sample_text.txt").ToList();
                List<char> chars = new List<char>() { '.', ',', '!', '?', ':' };
                List<char> chars2 = new List<char>();
                foreach (string line in lines)
                {
                    char[] line1 = line.ToCharArray();

                    foreach (char a in line1)
                    {
                        if (chars.Contains(a)) chars2.Add(a);
                    }
                }

                Console.WriteLine(string.Join(", ", chars2));
            }
            catch(FileNotFoundException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }
    }
}
