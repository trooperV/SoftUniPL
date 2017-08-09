using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex10_Student_Groups
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = ReadTownAndStudents();
            List<Group> groups = DistributeStudentsIntoGroups(towns);

            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");
       
            foreach (Group group in groups.OrderBy(a => a.Town.Name))
            {
                List<string> emailsTemp = new List<string>();
                foreach (Student student in group.Students)
                {
                    emailsTemp.Add(student.Email);
                }
                Console.WriteLine($"{group.Town.Name}=> {string.Join(", ", emailsTemp)}");
            }

        }

        static List<Town> ReadTownAndStudents()
        {
            List<Town> towns = new List<Town>();
            while (true)
            {
                string input = Console.ReadLine();
                List<string> input1 = input.Split().ToList();
                List<string> input2 = input.Split('|').ToList();
                if (input == "End") break;
                List<string> input3 = input.Split(new string[] {"=>"}, StringSplitOptions.None).ToList();
                if (input1.Contains("=>"))
                {
                    Town temp = new Town();
                    temp.Name = input3[0];
                    string[] input4 = input3[1].Split();
                    temp.SeatsCount = int.Parse(input4[1]);
                    temp.Students = new List<Student>();
                    towns.Add(temp);
                }
                else
                {
                    Student temp = new Student();
                    temp.Name = input2[0].Trim();
                    temp.Email = input2[1].Trim();
                    temp.RegistrationDate = DateTime.ParseExact(input2[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    towns.Last().Students.Add(temp);
                }
            }
            return towns;
        }

        static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();
            foreach (Town town in towns.OrderBy(a => a.Name))
            {
                IEnumerable<Student> students = town.Students
                    .OrderBy(a => a.RegistrationDate).ThenBy(a => a.Name).ThenBy(a => a.Email);

                while (students.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }
            return groups;
        }
    }
}

