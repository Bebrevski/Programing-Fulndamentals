using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Star__Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> record =
                new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (!input.Equals("report"))
            {
                string[] tokens = input.Split('|');

                string country = tokens[1];
                string city = tokens[0];
                long population = long.Parse(tokens[2]);

                if (!record.ContainsKey(country))
                {
                    record.Add(country, new Dictionary<string, long>());
                }
                if (!record[country].ContainsKey(city))
                {
                    record[country].Add(city, 0);
                }

                record[country][city] = population;

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> country in
                record.OrderByDescending(country => country.Value.Values.Sum()))
            {
                Console.WriteLine("{0} (total population: {1})"
                    , country.Key
                    , country.Value.Values.Sum());

                foreach (KeyValuePair<string, long> city in
                    country.Value.OrderByDescending(c=>c.Value))
                {
                    Console.WriteLine("=>{0}: {1}"
                        , city.Key
                        , city.Value);
                }
            }
        }
    }
}
