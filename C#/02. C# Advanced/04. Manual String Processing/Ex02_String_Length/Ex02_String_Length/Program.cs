using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_String_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string a2;
            if(a.Length > 20)
            {
                a2 = a.Substring(0, 20);
                Console.WriteLine(a2);
            }else if(a.Length == 20)
            {
                Console.WriteLine(a);
            }
            else
            {
                StringBuilder b = new StringBuilder();
                a2 = a.Substring(0, a.Length);
                b.Append(a2);
                while(b.Length != 20)
                {
                    b.Append('*');
                }
                Console.WriteLine(b.ToString());
            }
            

        }
    }
}
