using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            uint days = uint.Parse(Console.ReadLine());
            uint runners = uint.Parse(Console.ReadLine());
            byte laps = byte.Parse(Console.ReadLine());
            uint lapLength = uint.Parse(Console.ReadLine());
            uint capacity = uint.Parse(Console.ReadLine());
            decimal moneyPK = decimal.Parse(Console.ReadLine());


            uint maxRunners = capacity * days;
            uint allRunners = Math.Min(maxRunners, runners);
            long totalm = (long)allRunners * laps * lapLength;
            decimal totalK = totalm / 1000;
            decimal totalM = totalK * moneyPK;

            Console.WriteLine($"Money raised: {totalM:f2}");

        }
    }
}
