using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Find_Evens_Or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string w = Console.ReadLine();

            Predicate<int> isEven = a => a % 2 == 0;

            for (int i = range[0]; i < range[1]+1; i++)
            {
                if(w == "odd")
                {
                    if (!isEven(i)) Console.Write(i + " ");
                }
                else
                {
                    if (isEven(i)) Console.Write(i + " ");
                }
            }
        }
    }
}
