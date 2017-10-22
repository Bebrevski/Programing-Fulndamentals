using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> record =
                new Dictionary<string, List<string>>();

            Dictionary<string, int> output = new Dictionary<string, int>();

            while (!input.Equals("Blaze it!"))
            {
                string[] tokens = input
                    .Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                string creature = tokens[0];
                string squadMate = tokens[1];

                if (creature.Equals(squadMate))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!record.ContainsKey(creature))
                {
                    record.Add(creature, new List<string>());
                }
                if (record[creature].Contains(squadMate))
                {
                    input = Console.ReadLine();
                    continue;
                }
                record[creature].Add(squadMate);

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> team in record)
            {
                output.Add(team.Key, 0);

                foreach (string squad in team.Value)
                {
                    if (record.ContainsKey(squad) && record[squad].Contains(team.Key))
                    {
                        continue;
                    }
                    else
                    {
                        output[team.Key]++;
                    }
                }
            }

            foreach (KeyValuePair<string, int> team in
                output.OrderByDescending(t => t.Value))
            {
                Console.WriteLine("{0} : {1}", team.Key, team.Value);
            }
        }
    }
}
