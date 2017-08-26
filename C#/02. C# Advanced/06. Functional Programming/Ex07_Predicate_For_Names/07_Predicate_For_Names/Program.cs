using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Predicate<string> isCool = x => x.Length <= n;
            Action<string> pr = d => Console.WriteLine(d);
            names.Where(a => isCool(a) == true).ToList().ForEach(z => pr(z));
        }
    }
}
