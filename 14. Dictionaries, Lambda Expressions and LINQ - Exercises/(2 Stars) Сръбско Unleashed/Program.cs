using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_Stars__Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> record =
                new Dictionary<string, Dictionary<string, long>>();

            Regex pattern = new Regex(@"^(?<singer>[\w- ]+)(?:\s@)(?<venue>[\w- ]+)(?<=\s)(?<price>[0-9]+)\s(?<tickets>[0-9]+)$");

            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                if (pattern.IsMatch(input))
                {
                    Match match = pattern.Match(input);

                    string venue = match.Groups[2].Value.Trim();
                    string singer = match.Groups[1].Value;
                    long totalMoney = long.Parse(match.Groups[3].Value) * long.Parse(match.Groups[4].Value);

                    if (!record.ContainsKey(venue))
                    {
                        record.Add(venue, new Dictionary<string, long>());
                    }
                    if (!record[venue].ContainsKey(singer))
                    {
                        record[venue].Add(singer, 0);
                    }
                    record[venue][singer] += totalMoney;
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> place in record)
            {
                Console.WriteLine(place.Key);

                foreach (KeyValuePair<string, long> singer in
                    place.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}"
                        , singer.Key
                        , singer.Value);
                }
            }
        }
    }
}
