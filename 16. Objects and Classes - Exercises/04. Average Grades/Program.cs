using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double Average { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> record = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                List<string> tokens = Console.ReadLine().Split().ToList();

                string name = tokens[0];

                List<double> grades = new List<double>();
                tokens.RemoveAt(0);
                grades.AddRange(tokens.Select(double.Parse));

                double average = grades.Average();

                Student current = new Student()
                {
                    Name = name,
                    Grades = grades,
                    Average = average
                };

                record.Add(current);
            }

            foreach (Student stud in
                record.Where(x => x.Average >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.Average))
            {
                Console.WriteLine("{0} -> {1:f2}"
                    , stud.Name
                    , stud.Average);
            }
        }
    }
}
