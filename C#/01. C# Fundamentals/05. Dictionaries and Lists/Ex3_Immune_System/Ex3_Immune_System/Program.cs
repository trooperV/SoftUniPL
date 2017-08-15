using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int initStr = int.Parse(Console.ReadLine());
            int remainingStr = initStr;

            List<string> flues = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;

                int strength;
                int duration;
                if (!flues.Contains(input))
                {
                    flues.Add(input);
                    strength = VStr(input);
                    duration = strength * input.Length;
                }
                else
                {
                    strength = VStr(input);
                    duration = (strength * input.Length) / 3;
                }

                remainingStr -= duration;

                Console.WriteLine($"Virus {input}: {strength} => {duration} seconds");

                if (remainingStr <= 0) break;

                Console.WriteLine($"{input} defeated in {duration / 60}m {duration % 60}s.");
                Console.WriteLine($"Remaining health: {remainingStr}");

                remainingStr += remainingStr / 5;
                if (remainingStr > initStr) remainingStr = initStr;
            }

            if (remainingStr > 0) Console.WriteLine($"Final Health: {remainingStr}");
            else Console.WriteLine($"Immune System Defeated.");
        }

        static int VStr(string v)
        {
            int count = 0;
            foreach (char a in v)
            {
                count += a;
            }

            count /= 3;
            return count;
        }
    }
}
