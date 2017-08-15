using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Write_To_File
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = File.ReadAllLines("sample_text.txt").ToList();
            List<char> chars = new List<char>() { '.', ',', '!', '?', ':' };

            foreach (string line in lines)
            {
                char[] line1 = line.ToCharArray();

                for (int i = 0; i < line1.Length; i++)
                {
                    if (!chars.Contains(line1[i])) Console.Write(line1[i]);
                }
                Console.WriteLine();
            }


        }
    }
}
