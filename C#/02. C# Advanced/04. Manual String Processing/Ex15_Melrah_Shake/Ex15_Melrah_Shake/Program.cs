using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            bool canShake = true;

            while (canShake)
            {
                int indexFirst = input.IndexOf(pattern);
                int indexLast = input.LastIndexOf(pattern);
                if (indexFirst > -1 && indexLast > -1 && pattern.Length > 0 && indexFirst != indexLast)
                {
                    input = input.Remove(indexFirst, pattern.Length);
                    indexLast = input.LastIndexOf(pattern);
                    input = input.Remove(indexLast, pattern.Length);
                    Console.WriteLine("Shaked it.");
                    if (pattern.Length > 0)
                    {
                        pattern = pattern.Remove(pattern.Length / 2, 1);
                    }
                }
                else
                {
                    Console.WriteLine("No shake.");
                    canShake = false;
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
