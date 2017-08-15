using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> drivers = Console.ReadLine().Split().ToList();
            List<double> points = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<int> checkoints = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (string driver in drivers)
            {
                double fuel = driver[0];

                for (int i = 0; i < points.Count; i++)
                {
                    if(checkoints.Any(a => a == i))
                    {
                        fuel += points[i];
                    }
                    else
                    {
                        fuel -= points[i];
                        if(fuel <= 0)
                        {
                            Console.WriteLine($"{driver} - reached {i}");
                            break;
                        }
                    }
                }

                if(fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
            }
        }
    }
}
