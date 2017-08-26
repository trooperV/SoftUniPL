using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Func<int, int> add = n => n += 1;
            Func<int, int> subtract = n => n -= 1;
            Func<int, int> multiply = n => n * 2;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end") break;

                switch (command)
                {
                    case "add": numbers = numbers.Select(add).ToList(); break;
                    case "subtract": numbers = numbers.Select(subtract).ToList(); break;
                    case "multiply": numbers = numbers.Select(multiply).ToList(); break;
                    case "print": Console.WriteLine(string.Join(" ", numbers)); break;
                    default: break;
                }
            }
        }
    }
}
