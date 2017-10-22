using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> record =
                new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (!input.Equals("It's Training Men!"))
            {
                string[] tokens = input
                    .Split(new[] { "->", ":" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => t.Trim())
                    .ToArray();

                if (tokens.Length.Equals(3))
                {
                    string train = tokens[0];
                    string wagon = tokens[1];
                    int power = int.Parse(tokens[2]);

                    if (!record.ContainsKey(train))
                    {
                        record.Add(train, new Dictionary<string, int>());
                    }
                    if (!record[train].ContainsKey(wagon))
                    {
                        record[train].Add(wagon, 0);
                    }
                    record[train][wagon] += power;

                }
                else if (tokens.Length.Equals(2))
                {
                    string train = tokens[0];
                    string otherTrain = tokens[1];

                    if (record.ContainsKey(train))
                    {
                        foreach (KeyValuePair<string, int> OtherTrain in record[otherTrain])
                        {
                            record[train].Add(OtherTrain.Key, OtherTrain.Value);
                        }

                        record.Remove(otherTrain);
                    }
                    else
                    {
                        record.Add(train, new Dictionary<string, int>());

                        foreach (KeyValuePair<string, int> OtherTrain in record[otherTrain])
                        {
                            record[train].Add(OtherTrain.Key, OtherTrain.Value);
                        }

                        record.Remove(otherTrain);
                    }

                }
                else if (tokens.Length.Equals(1))
                {
                    string[] equals = tokens[0].Split('=').Select(t => t.Trim()).ToArray();

                    string train = equals[0];
                    string otherTrain = equals[1];

                    if (record.ContainsKey(train))
                    {
                        record[train].Clear();

                        foreach (KeyValuePair<string, int> OtherTrain in record[otherTrain])
                        {
                            record[train].Add(OtherTrain.Key, OtherTrain.Value);
                        }
                    }
                    else
                    {
                        record.Add(train, new Dictionary<string, int>());

                        foreach (KeyValuePair<string, int> OtherTrain in record[otherTrain])
                        {
                            record[train].Add(OtherTrain.Key, OtherTrain.Value);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> train in
                record.OrderByDescending(t => t.Value.Values.Sum())
                      .ThenByDescending(t => t.Value.Values.Count()))
            {
                Console.WriteLine("Train: {0}", train.Key);

                foreach (KeyValuePair<string, int> wagon in
                    train.Value.OrderByDescending(w => w.Value))
                {
                    Console.WriteLine("###{0} - {1}"
                        , wagon.Key
                        , wagon.Value);
                }
            }
        }
    }
}
