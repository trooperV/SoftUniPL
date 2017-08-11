using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dayStart = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime dayFinish = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays =
            {
                new DateTime(4, 01, 01),
                new DateTime(4, 03, 03),
                new DateTime(4, 05, 01),
                new DateTime(4, 05, 06),
                new DateTime(4, 05, 24),
                new DateTime(4, 09, 06),
                new DateTime(4, 09, 22),
                new DateTime(4, 11, 01),
                new DateTime(4, 12, 24),
                new DateTime(4, 12, 25),
                new DateTime(4, 12, 26)
            };

            int workingDays = 0;
            for (DateTime dayNow = dayStart; dayNow <= dayFinish; dayNow = dayNow.AddDays(1))
            {
                DateTime temp = new DateTime(4, dayNow.Month, dayNow.Day);

                if (!holidays.Contains(temp) && !dayNow.DayOfWeek.Equals(DayOfWeek.Saturday) && !dayNow.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                     workingDays++;
                }
                
            }

            Console.WriteLine(workingDays);
        }
    }
}
