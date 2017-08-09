using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            double sum = 0;
            foreach (string str in input)
            {
                char first = str.First();
                char last = str.Last();

                double num = double.Parse(str.Substring(1, str.Length-2));

                GetPositionInAlphabet(first,ref num, true);
                GetPositionInAlphabet(last, ref num, false);

                sum += num;
            }

            Console.WriteLine("{0:f2}", sum);
        }

        public static void GetPositionInAlphabet(char ch, ref double num, bool first)
        {
            if (char.IsUpper(ch))
            {
                int place = (ch - 'A') + 1;
                if (first) num /= place;
                else num -= place;
            }
            else
            {
                int place = (ch - 'a') + 1;
                if (first) num *= place;
                else num += place;
            }
        }
    }
}
