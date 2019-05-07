using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                List<double> grades = input.Skip(1).Select(double.Parse).ToList();
                students.Add(new Student(name,grades));
            }
            
            students = students.OrderBy(s=> s.Name).ThenByDescending(s=>s.AverageGrade).Where(s=>s.AverageGrade>=5).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }

    class Student
    {
        public string Name { get; }
        public List<double> Grades { get; }
        public double AverageGrade { get { return Grades.Average(); } }

        public Student(string name,List<double> grades)
        {
            this.Name = name;
            this.Grades = grades;
        }
    }
}
