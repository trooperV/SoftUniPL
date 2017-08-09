using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] r1 = Console.ReadLine().Split(' ');
            long jewels = long.Parse(r1[0]);
            long gold = long.Parse(r1[1]);

            string[] arr = Console.ReadLine().Split(' ');
            long jC = 0;
            long gC = 0;
            long sum = 0;
            long heSum = 0;

            while (arr[0] != "Jail" && arr[1] != "Time")
            {
                char[] expr = arr[0].ToCharArray();
                long he = long.Parse(arr[1]);

                for (int i = 0; i < expr.Length; i++)
                {
                    if (expr[i] == '$')
                    {
                        gC++;
                    }

                    if (expr[i] == '%')
                    {
                        jC++;
                    }
                }

                sum = sum + (jC * jewels) + (gC * gold);
                heSum += he;

                jC = 0;
                gC = 0;

                arr = Console.ReadLine().Split(' ');
            }

            if(sum >= heSum)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.", sum - heSum);
            }
            else
            {
                Console.WriteLine("Have to find another job. Lost: {0}.", heSum - sum);
            }
        }
    }
}
