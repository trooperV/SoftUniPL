using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> people = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                string name = input[0];
                input.RemoveAt(0);
                double[] grades = input.Select(double.Parse).ToArray();

                Student temp = new Student();
                temp.Name = name;
                temp.Grades = grades;

                people.Add(temp);
            }

            foreach (Student person in people.Where(a => a.AverageGrade >= 5).OrderBy(a => a.Name).ThenByDescending(a => a.AverageGrade))
            {
                    Console.WriteLine($"{person.Name} -> {person.AverageGrade:f2}");

            }
        }
    }
}
