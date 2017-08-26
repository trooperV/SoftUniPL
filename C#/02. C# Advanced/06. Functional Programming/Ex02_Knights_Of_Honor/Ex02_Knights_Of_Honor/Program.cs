using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Knights_Of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = a => Console.WriteLine("Sir " + a);
            Console.ReadLine().Split(' ').ToList().ForEach(a => print(a));
        }
    }
}
