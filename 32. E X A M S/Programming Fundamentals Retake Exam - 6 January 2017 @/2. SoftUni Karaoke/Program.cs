using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> record =
                new Dictionary<string, HashSet<string>>();

            string[] participents = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            string[] songs = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();

            while (!input.Equals("dawn"))
            {
                string[] tokens = input
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = tokens[0];
                string song = tokens[1];
                string reward = tokens[2];

                if (participents.Contains(name) && songs.Contains(song))
                {
                    if (!record.ContainsKey(name))
                    {
                        record.Add(name, new HashSet<string>());
                    }
                    record[name].Add(reward);
                }

                input = Console.ReadLine();
            }

            if (record.Count.Equals(0))
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (KeyValuePair<string, HashSet<string>> person in
                record.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1} awards"
                    , person.Key
                    , person.Value.Count);
                foreach (string item in person.Value.OrderBy(x=>x))
                {
                    Console.WriteLine("--{0}",item);
                }
            }
        }
    }
}
