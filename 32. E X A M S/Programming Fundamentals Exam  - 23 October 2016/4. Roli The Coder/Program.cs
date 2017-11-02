using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Roli_The_Coder
{
    class Event
    {
        public string ID { get; set; }
        public string EventName { get; set; }
        public List<string> Participants { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Event> record = new List<Event>();

            string input;
            while (!(input = Console.ReadLine()).Equals("Time for Code"))
            {
                string[] tokens = input
                    .Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                string id = tokens[0];

                if (!tokens[1].StartsWith("#")) continue;
                string eventName = tokens[1];

                List<string> participants = new List<string>();
                participants.AddRange(tokens.Skip(2).Distinct().Where(p=>p.StartsWith("@")));

                Event currentEvent = new Event()
                {
                    ID = id,
                    EventName = eventName,
                    Participants = participants
                };

                if (record.Any(e => e.ID.Equals(id)))
                {
                    if (record.Where(x => x.ID == id).First().EventName == eventName)
                    {
                        record.Where(x => x.ID == id).First().Participants.AddRange(tokens.Skip(2).Distinct());
                    }
                }
                else
                {
                    record.Add(currentEvent);
                }
            }

            record = record.OrderByDescending(e => e.Participants.Count())
                .ThenBy(e => e.EventName).ToList();



            foreach (Event party in record)
            {
                Console.WriteLine("{0} - {1}"
                    , party.EventName.TrimStart('#')
                    , party.Participants.Distinct().Count());

                foreach (string person in party.Participants.Distinct().OrderBy(p => p))
                {
                    Console.WriteLine(person);
                }
            }
        }
    }
}




//namespace RoliTheCoder
//{
//    class Program
//    {
//        static void Main()
//        {
//            List<Event> events = new List<Event>();

//            string input = Console.ReadLine();

//            string eventNamePattern = @"((?<=#)[\w\d-]+)";

//            while (!input.Equals("Time for Code"))
//            {
//                int id = int.Parse(input.Split(' ')[0]);

//                Match match = Regex.Match(input, eventNamePattern);
//                if (match.Success)
//                {
//                    string eventName = Regex.Match(input, eventNamePattern).Value;

//                    string[] names = input.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Skip(2).ToArray()
//                        .Where(x => x.StartsWith("@")).Select(x => x = x.Substring(1)).ToArray();

//                    bool idExist = events.Any(x => (x.Id == id));


//                    if (!idExist)
//                    {
//                        events.Add(new Event(id, eventName, names));
//                    }
//                    else if (idExist)
//                    {
//                        if (events.Where(x => x.Id == id).First().Name == eventName)
//                        {
//                            events.Where(x => x.Id == id).First().participants.UnionWith(names);
//                        }
//                    }
//                }


//                input = Console.ReadLine();
//            }

//            foreach (var e in events.OrderByDescending(x => x.participants.Count))
//            {
//                Console.WriteLine("{0} - {1}", e.Name, e.participants.Count());
//                foreach (var participant in e.participants.OrderBy(x => x))
//                {
//                    Console.WriteLine("@{0}",participant);
//                }
//            }

//        }
//    }

//    class Event
//    {
//        public int Id { get; set; }

//        public string Name { get; set; }

//        public HashSet<string> participants { get; set; }

//        public Event(int id, string name, IEnumerable<string> s)
//        {
//            this.Id = id;
//            this.Name = name;
//            this.participants = new HashSet<string>(s);
//        }
//    }
//}
