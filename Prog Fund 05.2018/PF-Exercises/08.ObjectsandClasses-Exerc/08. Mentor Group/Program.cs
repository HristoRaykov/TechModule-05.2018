using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line.Equals("end of dates"))
                {
                    break;
                }
                string[] input = line.Split();
                string name = input[0];
                List<DateTime> dates = new List<DateTime>();
                if (input.Length>1)
                {
                    dates = input[1].Split(',').Select(d => DateTime.ParseExact(d,"dd/MM/yyyy",CultureInfo.InvariantCulture)).ToList();
                }
                if (students.Exists(s=>s.Name.Equals(name))==false)
                {
                Student student = new Student(name,new List<DateTime>(),new List<string>());
                students.Add(student);
                }
                students.Find(s => s.Name == name).AttendanceDates.AddRange(dates);
                students.Find(s => s.Name == name).AttendanceDates.Sort();
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line.Equals("end of comments"))
                {
                    break;
                }
                string[] input = line.Split('-');
                string name = input[0];
                string comment = input[1];
                
                if (students.Exists(s => s.Name.Equals(name)))
                {
                    students.Find(s => s.Name == name).Comments.Add(comment);
                }
                
            }
           
            students = students.OrderBy(s => s.Name).ToList();
            

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}");
                Console.WriteLine("Comments:");
                if (student.Comments.Count>0)
                {
                    foreach (var comment in student.Comments)
                    {
                    Console.WriteLine($"- {comment}");
                    }
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.AttendanceDates)
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }

            Console.WriteLine();
        }
    }

    class Student
    {
        public string Name { get; }
        public List<DateTime> AttendanceDates { get; set; }
        public List<string> Comments { get; set; }

        public Student(string name, List<DateTime> attendanceDates, List<string> comments)
        {
            this.Name = name;
            this.AttendanceDates = attendanceDates;
            this.Comments = comments;
        }
    }
}
