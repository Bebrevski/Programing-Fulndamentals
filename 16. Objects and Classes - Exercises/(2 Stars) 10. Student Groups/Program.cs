using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Stars__10.Student_Groups
{
    class Town
    {
        public string Towns { get; set; }
        public int Seats { get; set; }
        public List<Student> Students { get; set; }
    }
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
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
            List<Town> towns = ReadTownsAndStudents();

            List<Group> groups = DistributeStudentsIntoGroups(towns);


            Console.WriteLine("Created {0} groups in {1} towns:", groups.Count, towns.Count);

            foreach (Group group in groups)
            {
                Console.Write("{0} => ", group.Town.Towns);

                string output = string.Empty;
                foreach (Student student in group.Students)
                {
                    output += student.Email + ", ";
                }
                Console.WriteLine(output.Substring(0, output.Length - 2));
            }
        }

        private static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();

            foreach (Town town in towns.OrderBy(t => t.Towns))
            {
                IEnumerable<Student> students = town.Students
                    .OrderBy(s => s.Date)
                    .ThenBy(s => s.Name)
                    .ThenBy(s => s.Email);

                while (students.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.Seats).ToList();

                    students = students.Skip(group.Town.Seats);

                    groups.Add(group);
                }
            }

            return groups;
        }

        private static List<Town> ReadTownsAndStudents()
        {
            List<Town> record = new List<Town>();

            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                if (input.Contains(" => "))
                {
                    string[] tokens = input.Split(new[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

                    string town = tokens[0];
                    string[] takeSeats = tokens[1].Split();
                    int seats = int.Parse(takeSeats[0]);

                    Town currentTown = new Town()
                    {
                        Towns = town,
                        Seats = seats,
                        Students = new List<Student>()
                    };

                    record.Add(currentTown);
                }
                else
                {
                    string[] tokens = input.Split('|').Select(x => x.Trim()).ToArray();

                    string name = tokens[0];
                    string email = tokens[1];
                    DateTime date = DateTime.ParseExact(tokens[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    Student currentStudent = new Student()
                    {
                        Name = name,
                        Email = email,
                        Date = date
                    };

                    record[record.Count - 1].Students.Add(currentStudent);
                }

                input = Console.ReadLine();
            }
            return record;
        }
    }
}