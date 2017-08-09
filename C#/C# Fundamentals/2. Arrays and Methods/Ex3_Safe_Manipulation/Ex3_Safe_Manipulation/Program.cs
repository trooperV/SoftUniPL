using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            string[] com = Console.ReadLine().Split(' ');
            while (com[0] != "END")
            {
                switch (com[0])
                {
                    case "Distinct":
                        {
                            arr = arr.Distinct().ToArray();
                        }
                        break;

                    case "Reverse":
                        {
                            Array.Reverse(arr);
                        }
                        break;

                    case "Replace":
                        {
                            int index = int.Parse(com[1]);
                            string el = com[2];
                            if(index < 0 || index >= arr.Length)
                            {
                                Console.WriteLine("Invalid input!");
                                break;
                            }
                            arr[index] = el;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                }

                com = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}


