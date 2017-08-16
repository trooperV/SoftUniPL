using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<long> l = new Stack<long>();

            long n = long.Parse(Console.ReadLine());

            l.Push(0);
            l.Push(1);

            for (long i = 0; i < n-1; i++)
            {
                long tempP = l.Peek();
                long next = l.Pop() + l.Peek();
                l.Push(tempP);
                l.Push(next);
            }

            Console.WriteLine(l.Peek());
        }
    }
}
