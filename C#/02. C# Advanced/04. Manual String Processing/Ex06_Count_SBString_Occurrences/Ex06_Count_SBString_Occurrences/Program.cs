using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Count_SBString_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int count = 0;

            while (true)
            {
                var index = text.IndexOf(pattern);

                if (index == -1) break;

                count++;
                text = text.Substring(index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
