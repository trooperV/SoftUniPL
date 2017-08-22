using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Text_Filler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bans = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (string str in bans)
            {
                text = text.Replace(str, new string('*', str.Length));
            }

            Console.WriteLine(text);
        }
    }
}
