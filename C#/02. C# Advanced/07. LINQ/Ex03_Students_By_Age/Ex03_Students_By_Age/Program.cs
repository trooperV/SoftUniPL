using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Students_By_Age
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

            IEnumerable<string> students = studs.Where(s => int.Parse(s[2]) >= 18 && int.Parse(s[2]) <= 24).Select(s => s[0] + " " + s[1] + " " + s[2]);

            Console.WriteLine(string.Join("\n", students));
        }
    }
}
