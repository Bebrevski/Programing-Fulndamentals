using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(' ')
                .Select(x => x.ToLower())
                .ToList();

            Dictionary<string, int> record = new Dictionary<string, int>();

            foreach (string word in input)
            {
                if (!record.ContainsKey(word))
                {
                    record.Add(word, 0);
                }
                record[word]++;
            }

            Console.WriteLine(string.Join(", ", record
                .Where(x => x.Value % 2 != 0)
                .ToDictionary(x => x.Key, x => x.Value)
                .Keys));
        }
    }
}
