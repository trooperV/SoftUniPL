using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09__Students_Enrolled
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
            string[] enrollmentYears = { "14", "15" };
            studs.Where(s => enrollmentYears.Any(y => s[0].EndsWith(y))).Select(s => s.Skip(1)).ToList().ForEach(s => Console.WriteLine(string.Join(" ", s)));
        }
    }
}
