using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Multiply_Big_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine().TrimStart('0');
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Mul(n1, n2));
        }

        static string Mul(string n1, int n2)
        {
            if (n2 == 0) return "0";
            n1 = Reverse(n1);

            int[] firstd = n1.Select(x => int.Parse(x.ToString())).ToArray();

            StringBuilder answer = new StringBuilder(51);

            int increment = 0;
            for (int i = 0; i < firstd.Length; i++)
            {
                int nextV = (firstd[i] * n2) + increment;
                answer.Append(nextV % 10);
                increment = nextV / 10;
            }

            if (increment != 0)
            {
                answer.Append(increment);
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
