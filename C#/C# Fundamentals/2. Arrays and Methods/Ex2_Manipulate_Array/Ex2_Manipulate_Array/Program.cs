using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] com = Console.ReadLine().Split(' ');

                switch (com[0])
                {
                    case "Distinct":{
                            arr = arr.Distinct().ToArray();
                        }
                        break;

                    case "Reverse":{
                            Array.Reverse(arr);
                        }
                        break;

                    case "Replace":{
                            int index = int.Parse(com[1]);
                            string el = com[2];

                            arr[index] = el;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
