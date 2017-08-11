using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>(Console.ReadLine().Split());

            input.Sort();

            Console.WriteLine(string.Join(", ", input));

        }
    }
}
