using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int toSkip = n[0];
            int toTake = n[1];

            string input = Console.ReadLine();

            Regex pattern = new Regex(@"(?<camera>(?:(\|\<))(.*))");

            if (pattern.IsMatch(input))
            {
                string[] tokens = pattern.Match(input)
                                         .Groups["camera"]
                                         .Value
                                         .Split(new[] { "|<"},
                                          StringSplitOptions.RemoveEmptyEntries)
                                         .Select(x=>x.Trim())
                                         .ToArray();

                List<string> record = new List<string>();
                foreach (string item in tokens)
                {
                    record.Add(new string(item.Skip(toSkip).Take(toTake).ToArray()));
                }
                Console.WriteLine(string.Join(", ",record));
            }
        }
    }
}
