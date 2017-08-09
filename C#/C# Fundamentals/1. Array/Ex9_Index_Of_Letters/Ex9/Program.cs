using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[26];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToChar(97 + i);
            }

            char[] arr2 = Console.ReadLine().ToCharArray();
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if(arr2[i] == arr[j])
                    {
                        Console.WriteLine("{0} -> {1}", arr2[i], j);
                    }
                }
            }
        }
    }
}
