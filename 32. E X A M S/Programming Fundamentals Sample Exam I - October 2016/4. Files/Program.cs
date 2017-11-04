using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> files = new List<string>();

            for (int i = 0; i < n; i++)
            {
                files.Add(Console.ReadLine());
            }

            string[] directory = Console.ReadLine()
                .Split(new[] { "in" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            string patter = @"^" + string.Format("{0}", directory[1]) +
                            @"\\.*?." +
                            string.Format("{0}", directory[0]) +
                            @";[0-9]+";
            Regex pattern = new Regex(patter);

            Dictionary<string, ulong> record = new Dictionary<string, ulong>();

            foreach (string file in files)
            {
                Match match = pattern.Match(file);

                if (match.Success)
                {
                    string[] tokens = file.Split(new[] { '\\', ';' }, StringSplitOptions.RemoveEmptyEntries);

                    string current = tokens[tokens.Length - 2];
                    ulong size = ulong.Parse(tokens.Last());

                    if (!record.ContainsKey(current))
                    {
                        record.Add(current, 0L);
                    }
                    record[current] = size;
                }
            }

            if (!record.Any())
            {
                Console.WriteLine("No");
                return;
            }
            foreach (KeyValuePair<string, ulong> file in
                record.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} - {1} KB", file.Key, file.Value);
            }
        }
    }
}
