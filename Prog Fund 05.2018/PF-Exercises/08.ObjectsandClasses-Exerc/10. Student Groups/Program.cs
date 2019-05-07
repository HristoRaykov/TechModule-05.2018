using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Student_Groups
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Town, List<Student>> towns = new Dictionary<Town, List<Student>>();
            List<Student> students = new List<Student>();
            Town currentTown = null;

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                if (line.Contains("=>"))
                {
                    string[] tokens = Regex.Split(line, "=>");
                    string townName = tokens[0].Trim();
                    int seats = int.Parse(tokens[1].Trim().Split()[0]);
                    currentTown = new Town(townName, seats);
                    if (towns.ContainsKey(currentTown) == false)
                    {
                        towns.Add(currentTown, new List<Student>());
                    }
                    students = towns[currentTown];
                }
                else
                {
                    string[] tokens = line.Split('|');
                    string studentName = tokens[0].Trim();
                    string email = tokens[1].Trim();
                    DateTime date = DateTime.ParseExact(tokens[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    students.Add(new Student(currentTown, studentName, email, date));
                }
            }

            Dictionary<Town, List<Student>> ordered = new Dictionary<Town, List<Student>>(towns);
            foreach (var town in towns.Keys)
            {
                students = towns[town];
                students = students.OrderBy(student => student.Date).ThenBy(s => s.Name).ThenBy(s => s.Email).ToList();
                ordered[town] = students;
            }
            ordered = ordered.OrderBy(kvp => kvp.Key.Name).ToDictionary(t => t.Key, t => t.Value);

            List<Group> groups = new List<Group>();

            foreach (var town in ordered.Keys)
            {
                students = ordered[town];
                Group group = new Group(town, new List<Student>());
                foreach (var student in students)
                {
                    if (group.Capacity <= group.Students.Count)
                    {
                        groups.Add(group);
                        group = new Group(town, new List<Student>());
                    }
                    group.Students.Add(student);
                }
                groups.Add(group);
            }

            int numberOfTowns = ordered.Count;
            Console.WriteLine($"Created {groups.Count} groups in {numberOfTowns} towns:");
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Town.Name} => {string.Join(", ",group.EmailList)}");
            }


            Console.WriteLine();
        }
    }

    class Town
    {
        public string Name { get; }
        public int Seats { get; }

        public Town(string name, int seats)
        {
            this.Name = name;
            this.Seats = seats;
        }
    }

    class Group
    {
        public Town Town { get; }
        public int Capacity { get { return Town.Seats; } }

        public List<Student> Students { get; set; }

        public List<string> EmailList
        {
            get
            {
                List<string> emails = new List<string>();
                foreach (var student in Students)
                {
                    emails.Add(student.Email);
                }
                return emails;
            }
        }

        public Group(Town town, List<Student> students)
        {
            this.Town = town;
            this.Students = students;
        }
    }

    class Student
    {
        public Town Town { get; }
        public string Name { get; }
        public string Email { get; }
        public DateTime Date { get; }

        public Student(Town town, string name, string email, DateTime date)
        {
            this.Town = town;
            this.Name = name;
            this.Email = email;
            this.Date = date;
        }
    }
}
