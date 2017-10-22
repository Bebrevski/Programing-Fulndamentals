using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mentor_Group
{
    class Student
    {
        public List<DateTime> Dates { get; set; }
        public List<string> Comments { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Student> record = new Dictionary<string, Student>();

            while (!input.Equals("end of dates"))
            {
                string[] tokens = input.Split();
                string name = tokens[0];

                List<DateTime> dates = new List<DateTime>();

                if (tokens.Length > 1)
                {
                    string[] data = tokens[1].Split(',');                   

                    foreach (string st in data)
                    {
                        dates.Add(DateTime.ParseExact(st, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }

                    Student current = new Student()
                    {
                        Dates = dates,
                        Comments = new List<string>()
                    };

                    if (!record.ContainsKey(name))
                    {
                        record.Add(name, current);
                    }
                    else
                    {
                        record[name].Dates.AddRange(dates);
                    }
                }
                else
                {
                    Student current = new Student()
                    {
                        Dates = new List<DateTime>(),
                        Comments = new List<string>()
                    };

                    if (!record.ContainsKey(name))
                    {
                        record.Add(name, current);
                    }
                    else
                    {
                        record[name].Dates.AddRange(dates);
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (!input.Equals("end of comments"))
            {
                string[] tokens = input.Split('-');

                string name = tokens[0];
                string comment = tokens[1];

                if (record.ContainsKey(name))
                {
                    record[name].Comments.Add(comment);
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Student> person in record.OrderBy(x => x.Key))
            {
                Console.WriteLine(person.Key);

                Console.WriteLine("Comments:");
                foreach (string comment in person.Value.Comments)
                {
                    Console.WriteLine("- {0}", comment);
                }

                Console.WriteLine("Dates attended:");
                foreach (DateTime date in person.Value.Dates.OrderBy(x => x))
                {
                    Console.WriteLine(@"-- {0:dd/MM/yyyy}", date.Date);
                }
            }
        }
    }
}
