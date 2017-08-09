using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Andrey_And_Billiard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> Items { get; set; }
        public double Bill { get; set; }
    };

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> items = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string[] input1 = Console.ReadLine().Split('-');
                if(!items.ContainsKey(input1[0])) items.Add(input1[0], 0);

                items[input1[0]] = double.Parse(input1[1]);
            }

            List<Customer> people = new List<Customer>();

            while (true)
            {
                string[] input2 = Console.ReadLine().Split('-');
                if (input2[0] == "end of clients") break;

                string[] item1 = input2[1].Split(',');
                Customer temp = new Customer();
                temp.Items = new Dictionary<string, int>();
                temp.Name = input2[0];
                temp.Items.Add(item1[0], int.Parse(item1[1]));
                temp.Bill = 0;
                if (!items.ContainsKey(item1[0])) continue;

                if (!people.Any(x => x.Name == temp.Name))
                {
                    people.Add(temp);
                }
                else
                {
                    Customer oldCustomer = people.First(x => x.Name == temp.Name);
                    if (!oldCustomer.Items.ContainsKey(item1[0])) oldCustomer.Items.Add(item1[0], 0);
                    oldCustomer.Items[item1[0]] += int.Parse(item1[1]);
                }
            }

            foreach (Customer customer in people)
            {
                foreach (KeyValuePair<string, int> item in customer.Items)
                {
                    foreach (KeyValuePair<string, double> product in items)
                    {
                        if (item.Key == product.Key) { customer.Bill += item.Value * product.Value; }
                    }
                }
            }

            List<Customer> ordered = people
                            .OrderBy(x => x.Name)
                            .ThenBy(x => x.Bill)
                            .ToList();
            foreach (Customer customer in ordered)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, int> item in customer.Items)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine("Bill: {0:f2}", customer.Bill);

            }
            Console.WriteLine("Total bill: {0:F2}", people.Sum(c => c.Bill));
        }
    }
}
