using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Group_By_Group
{
    public class Person
    {
        public string Name { get; set; }
        public int Group { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> studs = new List<Person>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "END") break;

                studs.Add(new Person
                {
                    Name = input[0] + " " + input[1],
                    Group = int.Parse(input[2])
                });
            }

            Dictionary<int, IEnumerable<string>> groups = studs.GroupBy(s => s.Group).OrderBy(g => g.Key).ToDictionary(g => g.Key, g => g.Select(m => m.Name));

            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key} - {string.Join(", ", group.Value)}");
            }
        }
    }
}
