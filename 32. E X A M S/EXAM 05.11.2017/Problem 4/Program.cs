using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> record =
                new Dictionary<string, Dictionary<string, long>>();

            Dictionary<string, Dictionary<string, long>> cashed = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (!input.Equals("thetinggoesskrra"))
            {
                string[] tokens = input.Split(new[] { " -> ", " | ", }, StringSplitOptions.RemoveEmptyEntries);

                string dataSet = string.Empty;
                string dataKey = string.Empty;
                long dataSize = 0L;

                if (tokens.Length == 1)
                {
                    dataSet = tokens[0];

                    if (!record.ContainsKey(dataSet))
                    {
                        record.Add(dataSet, new Dictionary<string, long>());
                    }
                }
                else
                {
                    dataKey = tokens[0];
                    dataSize = long.Parse(tokens[1]);
                    dataSet = tokens[2];

                    if (!cashed.ContainsKey(dataSet))
                    {
                        cashed.Add(dataSet, new Dictionary<string, long>());
                    }
                    if (!cashed[dataSet].ContainsKey(dataKey))
                    {
                        cashed[dataSet].Add(dataKey, 0L);
                    }
                    cashed[dataSet][dataKey] = dataSize;

                }

                input = Console.ReadLine();
            }


            string name = string.Empty;
            long sum = 0L;
            foreach (KeyValuePair<string, Dictionary<string, long>> item in cashed.OrderByDescending(x => x.Value.Values.Sum()))
            {
                if (record.ContainsKey(item.Key))
                {
                    record[item.Key] = cashed[item.Key];
                    name = item.Key;
                    sum = record[item.Key].Values.Sum();
                }
                break;
            }

            if (record.Count().Equals(0))
            {
                return;
            }

            Console.WriteLine("Data Set: {0}, Total Size: {1}",name,sum);
            foreach (KeyValuePair<string, Dictionary<string, long>> item in record.OrderByDescending(x => x.Value.Values.Sum()))
            {
                foreach (KeyValuePair<string, long> kvp in item.Value)
                {
                    Console.WriteLine("$.{0}", kvp.Key);
                }
            }
        }
    }
}
