using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double bananaC = double.Parse(Console.ReadLine());
            double eggsC = double.Parse(Console.ReadLine());
            double berriesKG = double.Parse(Console.ReadLine());

            int dishes = guests / 6;
            if (guests % 6 != 0) dishes += 1;

            double cost = dishes * 2 * bananaC + dishes * 4 * eggsC + dishes * 0.2 * berriesKG;
            if (cost > cash)
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {cost-cash:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {cost:f2}lv.");
            }
        }
    }
}