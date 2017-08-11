using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Morse_Code_Upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int sum = 0;
                int cur = 1;

                if (input[i][0] == '1')
                {
                    sum += 5;
                }
                else
                {
                    sum += 3;
                }

                for (int j = 1; j < input[i].Length; j++)
                {
                    if (input[i][j] == '1') sum += 5;
                    if (input[i][j] == '0') sum += 3;

                    if (input[i][j] == input[i][j - 1])
                    {
                        cur++;
                    }
                    else
                    {
                        if (cur != 1)
                        {
                            sum += cur;
                        }
                        cur = 1;
                    }

                    if(j == input[i].Length - 1 && cur != 1) { sum += cur; }
                }

                sb.Append((char)(sum));
            }
            Console.WriteLine(sb);
        }
    }
}
