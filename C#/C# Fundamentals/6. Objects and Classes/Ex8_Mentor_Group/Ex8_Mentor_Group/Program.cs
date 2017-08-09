using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex8_Mentor_Group
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> people = new List<Student>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "end") break;

                Student temp = new Student();
                temp.Name = input[0];

                if (input.Length > 1)
                {
                    List<DateTime> dates = input[1]
                        .Split(',')
                        .Select(a => DateTime.ParseExact(a, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                        .ToList();
                    temp.Dates = dates;
                }

                if(!people.Any(a => a.Name == temp.Name))
                {
                    people.Add(temp);
                }
                else
                {
                    foreach (Student person in people.Where(a => a.Name == temp.Name))
                    {
                        person.Dates.AddRange(temp.Dates);
                    }
                }
                
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split('-');
                if (input[0] == "end of comments") break;

                foreach (Student person in people.Where(a => a.Name == input[0]))
                {
                    if (person.Comments == null) person.Comments = new List<string>();

                    person.Comments.Add(input[1]);
                }
            }

            foreach (Student person in people.OrderBy(a => a.Name))
            {
                Console.WriteLine(person.Name);

                Console.WriteLine("Comments:");
                if (person.Comments != null)
                {
                    foreach (string comment in person.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }

                Console.WriteLine("Dates attended:");
                if (person.Dates != null)
                {
                    foreach (DateTime date in person.Dates.OrderBy(a => a.Date))
                    {
                        Console.WriteLine($"-- {date:dd/MM/yyyy}");
                    }
                }
            }
        }
    }
}
