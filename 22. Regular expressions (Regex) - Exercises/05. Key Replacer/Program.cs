using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = Console.ReadLine()
                .Split(new[] { '|', '<', '\\' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string start = keys.First();
            string end = keys.Last();

            string input = Console.ReadLine();

            string pattern = @"(?<=" + string.Format("{0}", start) + ")" +
                                @"(.*?)" +
                                @"(?=" + string.Format("{0}", end) + ")";

            Regex newRegex = new Regex(pattern);

            MatchCollection matches = newRegex.Matches(input);

            StringBuilder output = new StringBuilder();

            foreach (Match item in matches)
            {
                if (!(item.Value.Contains(start) && item.Value.Contains(end)))
                {
                    output.Append(item.Value);
                }
            }

            if (output.Length.Equals(0))
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(output);
            }

        }
    }
}
