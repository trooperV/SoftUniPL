using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Karate_String
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            int str = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    str += int.Parse(input[i + 1].ToString());

                    i++;

                    while (i < input.Length && str > 0)
                    {
                        if (input[i] == '>')
                        {
                            break;
                        }

                        input.Remove(i, 1);
                        str--;
                    }

                    i--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
