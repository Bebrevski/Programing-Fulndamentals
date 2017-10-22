using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worms_World_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> wormRecord =
                new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (!input.Equals("quit"))
            {
                string[] tokens = input
                    .Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                string teamName = tokens[1];
                string wormName = tokens[0];
                long wormScore = long.Parse(tokens[2].Trim());

                bool hasWorm = false;
                foreach (var kvp in wormRecord)
                {
                    if (kvp.Value.ContainsKey(wormName))
                    {
                        hasWorm = true;
                    }
                }

                if (hasWorm == false)
                {
                    if (!wormRecord.ContainsKey(teamName))
                    {
                        wormRecord.Add(teamName, new Dictionary<string, long>());
                    }

                    wormRecord[teamName].Add(wormName, 0);
                    wormRecord[teamName][wormName] += wormScore;
                }

                input = Console.ReadLine();
            }

            wormRecord = wormRecord
                .OrderByDescending(team => team.Value.Values.Sum())
                .ThenByDescending(team => team.Value.Values.Average())
                .ToDictionary(team => team.Key, team => team.Value);

            int counter = 1;
            foreach (KeyValuePair<string, Dictionary<string, long>> team in wormRecord)
            {
                Console.WriteLine("{0}. Team: {1} - {2}"
                    , counter
                    , team.Key
                    , team.Value.Values.Sum());

                foreach (KeyValuePair<string, long> worm in
                    team.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine("###{0} : {1}", worm.Key, worm.Value);
                }

                counter++;
            }
        }
    }
}
