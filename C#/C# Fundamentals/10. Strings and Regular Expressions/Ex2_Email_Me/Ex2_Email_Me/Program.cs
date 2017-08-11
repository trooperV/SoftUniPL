using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex2_Email_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] all = Regex.Split(Console.ReadLine(), "@");

            int sum1 = all[0].Sum(x => x);
            int sum2 = all[1].Sum(x => x);

            if((sum1 - sum2) >= 0){
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
