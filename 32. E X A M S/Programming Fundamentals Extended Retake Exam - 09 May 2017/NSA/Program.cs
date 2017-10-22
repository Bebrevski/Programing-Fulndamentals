using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> record =
                new Dictionary<string, Dictionary<string, long>>();

            while (!input.Equals("quit"))
            {
                string[] tokens = input
                    .Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => t.Trim())
                    .ToArray();

                string country = tokens[0];
                string name = tokens[1];
                long days = long.Parse(tokens[2]);

                if (!record.ContainsKey(country))
                {
                    record.Add(country, new Dictionary<string, long>());
                }
                if (!record[country].ContainsKey(name))
                {
                    record[country].Add(name, 0);
                }

                record[country][name] = days;

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> country in
                record.OrderByDescending(c => c.Value.Count()))
            {
                Console.WriteLine("Country: {0}", country.Key);

                foreach (KeyValuePair<string, long> name in 
                    country.Value.OrderByDescending(d => d.Value))
                {
                    Console.WriteLine("**{0} : {1}"
                        , name.Key
                        , name.Value);
                }
            }
        }
    }
}
