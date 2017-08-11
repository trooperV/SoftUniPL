using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Order_By_Age
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End") break;

                Person temp = new Person();
                temp.Name = input[0];
                temp.ID = input[1];
                temp.Age = int.Parse(input[2]);

                people.Add(temp);
            }

            foreach (Person person in people.OrderBy(a => a.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
