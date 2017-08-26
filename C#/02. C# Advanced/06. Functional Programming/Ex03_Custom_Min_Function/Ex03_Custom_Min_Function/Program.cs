using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<double>, double> minNum = a => a.Min();
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            Console.WriteLine(minNum(list));
        }
    }
}
