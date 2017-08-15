using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(500)));

            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);
            int startIndex = 0;
            int endIndex = 0;

            while ((startIndex = input.IndexOf('<', endIndex)) != -1 &&
                    (endIndex = input.IndexOf('>', startIndex)) != -1)
            {
                string bombChars = input.Substring(startIndex + 1, 3);
                int bombStrength = Math.Abs(bombChars[0] - bombChars[1]);

                int leftIndex = Math.Max(0, startIndex - bombStrength);
                int length = Math.Min(endIndex + bombStrength, input.Length - 1);

                for (int i = leftIndex; i <= length; i++)
                {
                    sb[i] = '_';
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
