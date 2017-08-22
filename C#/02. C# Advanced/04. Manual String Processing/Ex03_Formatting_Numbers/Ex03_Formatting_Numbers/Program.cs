using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(nums[0]);
            double b = double.Parse(nums[1]);
            double c = double.Parse(nums[2]);
            Console.Write("|");
            Console.Write("{0,-10:X}", a);
            Console.Write("|");
            string a2 = Convert.ToString(a, 2);
            if (a2.Length > 10)
            {
               a2 = a2.Substring(0, 10);
            }
            Console.Write(a2.PadLeft(10, '0'));
            Console.Write("|");
            Console.Write("{0,10:f2}", b);
            Console.Write("|");
            Console.Write("{0,-10:f3}", c);
            Console.Write("|");
        }
    }
}
