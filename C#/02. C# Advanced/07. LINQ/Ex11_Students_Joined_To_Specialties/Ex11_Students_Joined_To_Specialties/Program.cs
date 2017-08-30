using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Students_Joined_To_Specialties
{
    public class Student
    {
        public string StudentName { get; set; }
        public string FacultyNumber { get; set; }
    }
    public class StudentSpecialty
    {
        public string SpecialtyName { get; set; }
        public string StudentFacultyNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<StudentSpecialty> stdSpec = GetSpecialties();
            List<Student> std = GetStudents();

            std.Join(stdSpec, st => st.FacultyNumber, sp => sp.StudentFacultyNumber, (st, sp) => new {
                        StudentName = st.StudentName,
                        FacultyNumber = st.FacultyNumber,
                        SpecialtyName = sp.SpecialtyName
                    }).OrderBy(st => st.StudentName).ToList().ForEach(st => Console.WriteLine($"{st.StudentName} {st.FacultyNumber} {st.SpecialtyName}"));
        }

        static List<Student> GetStudents()
        {
            List<Student> std = new List<Student>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "END") break;

                Student temp = new Student();
                temp.FacultyNumber = input[0];
                temp.StudentName = input[1] + " " + input[2];
                std.Add(temp);
            }
            return std;
        }

        static List<StudentSpecialty> GetSpecialties()
        {
            List<StudentSpecialty> stdSpec = new List<StudentSpecialty>();
            while (true)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Students:") break;

                StudentSpecialty temp = new StudentSpecialty();
                temp.SpecialtyName = input[0] + " " + input[1];
                temp.StudentFacultyNumber = input[2];
                stdSpec.Add(temp);
            }
            return stdSpec;
        }
    }
}
