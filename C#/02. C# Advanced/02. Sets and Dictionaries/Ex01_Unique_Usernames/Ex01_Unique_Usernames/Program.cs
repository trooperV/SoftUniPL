using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> hashSet = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                hashSet.Add(input);
            }

            Console.WriteLine(string.Join("\n", hashSet));
        }
    }
}
