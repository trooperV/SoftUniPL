using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Softuni_Coffee_Orders
{
    class Coffee
    {
        public decimal PricePC { get; set; }
        public DateTime Date { get; set; }
        public long Capsules { get; set; }
        public decimal Price
        {
            get
            { return (DateTime.DaysInMonth(Date.Year, Date.Month) * Capsules) * PricePC; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Coffee> items = new List<Coffee>();
            decimal total = 0;
            for (int i = 0; i < n; i++)
            {
                Coffee temp = new Coffee();
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsules = long.Parse(Console.ReadLine());
                temp.PricePC = price;
                temp.Date = date;
                temp.Capsules = capsules;
                total += temp.Price;
                Console.WriteLine($"The price for the coffee is: ${temp.Price:F2}");
                items.Add(temp);
            }

            Console.WriteLine($"Total: ${total:F2}");


        }
    }
}
