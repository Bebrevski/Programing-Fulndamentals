using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> record = new Dictionary<string, int>();

            string[] tokens = File.ReadAllText("../../words.txt")
                .Split()
                .ToArray();

            for (int word = 0; word < tokens.Length; word++)
            {
                if (!record.ContainsKey(tokens[word]))
                {
                    record.Add(tokens[word], 0);
                }

            }

            using (StreamReader reader = new StreamReader("../../input.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine()
                                          .Split(new[] { ' ', ',', '.', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(w => w.ToLower())
                                          .ToArray();

                    foreach (string word in line)
                    {
                        if (record.ContainsKey(word))
                        {
                            record[word]++;
                        }
                    }
                }
            }

            StreamWriter writer = new StreamWriter(@"../../output.txt");
            foreach (var kvp in record.OrderByDescending(w => w.Value))
            {
                writer.WriteLine(kvp.Key + " - " + kvp.Value);
            }

            writer.Close();
        }
    }
}
