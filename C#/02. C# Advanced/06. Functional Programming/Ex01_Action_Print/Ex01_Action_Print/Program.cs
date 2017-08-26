using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = a => Console.WriteLine(a);
            Console.ReadLine().Split(' ').ToList().ForEach(a => print(a));
        }
    }
}
