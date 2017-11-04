using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4___Population_Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> record =
                new Dictionary<string, int>();

            Dictionary<string, ulong> recCity = new Dictionary<string, ulong>();

            string input = Console.ReadLine();

            while (!input.Equals("stop"))
            {
                string[] tokens = input.Split('\\');

                Regex countryPattern = new Regex(@"^[A-Z].*?$");
                Regex cityPattern = new Regex(@"^[a-z].*?$");

                string country = string.Empty;
                string city = string.Empty;
                ulong population = 0;
                if (countryPattern.IsMatch(tokens[0]) && cityPattern.IsMatch(tokens[1]))
                {
                    country = ClearString(tokens[0]);
                    city = ClearString(tokens[1]);
                    population = ulong.Parse(tokens[2]);
                }
                else if (cityPattern.IsMatch(tokens[0]) && countryPattern.IsMatch(tokens[1]))
                {
                    country = ClearString(tokens[1]);
                    city = ClearString(tokens[0]);
                    population = ulong.Parse(tokens[2]);
                }

                if (!record.ContainsKey(country))
                {
                    record.Add(country, 0);
                }
                record[country]++;

                if (!recCity.ContainsKey(city))
                {
                    recCity.Add(city, 0);
                }
                recCity[city] = population;

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string,int> c in 
                record.OrderBy(m=>m.Key))
            {
                Console.WriteLine("{0} -> {1}",c.Key,c.Value);
            }
            int count = 0;
            foreach (KeyValuePair<string,ulong> city in recCity.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine("{0} -> {1}",city.Key,city.Value);
                count++;
                if (count.Equals(3))
                {
                    return;
                }
            }
        }

        private static string ClearString(string country)
        {
            StringBuilder clear = new StringBuilder();
            for (int i = 0; i < country.Length; i++)
            {
                if (!(country[i].Equals('@') ||
                    country[i].Equals('#') ||
                    country[i].Equals('$') ||
                    country[i].Equals('&') ||
                    (country[i] >= '0' && country[i] <= '9')))
                {
                    clear.Append(country[i]);
                }
            }
            return clear.ToString();
        }
    }
}
