using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Filter_Students_By_Phone
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
            string[] prefixes = { "02", "+3592" };
            IEnumerable<string> students = studs.Where(s => prefixes.Any(p => s[2].StartsWith(p)))
                            .Select(s => s[0] + " " + s[1]);

            Console.WriteLine(string.Join("\n", students));
        }
    }
}
