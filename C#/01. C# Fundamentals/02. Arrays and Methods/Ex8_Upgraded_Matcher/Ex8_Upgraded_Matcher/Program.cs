using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            long[] arr2Input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long[] arr2 = new long[arr1.Length];
            for (int i = 0; i < arr2Input.Length; i++)
            {
                arr2[i] = arr2Input[i];
            }
            decimal[] arr3 = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            while (true)
            {
                string[] nameAll = Console.ReadLine().Split(' ');
                   
                if (nameAll[0] == "done")
                {
                    break;
                }
                    string name = nameAll[0];
                    long quant = long.Parse(nameAll[1]);
                foreach (string el in arr1)
                {
                    if (el == nameAll[0])
                    {
                        if (quant <= arr2[Array.IndexOf(arr1, nameAll[0])])
                        {
                            decimal total = quant * arr3[Array.IndexOf(arr1, name)];
                            arr2[Array.IndexOf(arr1, nameAll[0])] -= quant;
                            Console.WriteLine($"{name} x {quant} costs {total:f2}");
                        }
                        else
                        {
                            Console.WriteLine("We do not have enough {0}", name);
                        }
                    }
                }
                
            }
        }
    }
}
