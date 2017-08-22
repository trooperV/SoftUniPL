using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Sum_Big_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine().TrimStart('0');
            string n2 = Console.ReadLine().TrimStart('0');

            Console.WriteLine(Sum(n1, n2));
        }

        static string Sum(string n1, string n2)
        {
            n1 = Reverse(n1);
            n2 = Reverse(n2);

            int[] firstd = n1.Select(x => int.Parse(x.ToString())).ToArray();
            int[] secondd = n2.Select(x => int.Parse(x.ToString())).ToArray();

            StringBuilder answer = new StringBuilder(51);

            int increment = 0;
            for (int i = 0; i < (firstd.Length > secondd.Length ? secondd : firstd).Length; i++)
            {
                int nextV = firstd[i] + secondd[i] + increment;

                answer.Append(nextV % 10);

                increment = nextV / 10 > 0 ? 1 : 0;
            }

            for (int i = (firstd.Length > secondd.Length ? secondd : firstd).Length; i < (firstd.Length > secondd.Length ? firstd : secondd).Length; i++)
            {
                int nextV = ((firstd.Length > secondd.Length ? firstd : secondd)[i] + increment) % 10;
                answer.Append(nextV);

                increment = ((firstd.Length > secondd.Length ? firstd : secondd)[i] + increment) / 10 > 0 ? 1 : 0;
            }

            if (increment == 1)
            {
                answer.Append(1);
            }

            string a = answer.ToString();

            return Reverse(a);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
