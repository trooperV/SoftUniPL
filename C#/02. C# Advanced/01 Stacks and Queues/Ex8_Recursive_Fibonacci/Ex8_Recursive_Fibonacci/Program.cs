using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long[] l = new long[n+1];
            Console.WriteLine(fibonacci(n, l));
        }

        static long fibonacci(long n, long[] l)
        {
            if (n == 1 || n == 2) return 1;

            if (l[n] == 0)
            {
                l[n] = fibonacci(n - 1, l) + fibonacci(n - 2, l);
            }

            return l[n];
        }
    }
}
