using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] timeInput = Console.ReadLine().Split(':');
            int hours = int.Parse(timeInput[0]) * 3600;
            int minutes = int.Parse(timeInput[1]) * 60;
            int seconds = int.Parse(timeInput[2]);
            int totalInputInSeconds = hours + minutes + seconds;

            long steps = long.Parse(Console.ReadLine());
            long secPerStep = long.Parse(Console.ReadLine());

            long totalTimeInSeconds = (steps * secPerStep) + totalInputInSeconds;

            long arriveHour = (totalTimeInSeconds / 3600) % 24;
            long arriveMinute = (totalTimeInSeconds / 60) % 60;
            long arriveSecond = totalTimeInSeconds % 60;

            Console.WriteLine($"Time Arrival: {arriveHour:00}:{arriveMinute:00}:{arriveSecond:00}");
        }
    }
}
