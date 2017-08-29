﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_WeakStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> studs = new List<string[]>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "END") break;

                studs.Add(input);
            }

            IEnumerable<string> students = studs.Where(s => s.Skip(2).Select(int.Parse).Count(m => m <= 3) >= 2).Select(s => s[0] + " " + s[1]);

            Console.WriteLine(string.Join("\n", students));
        }
    }
}
