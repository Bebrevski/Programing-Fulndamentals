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
            string keys = Console.ReadLine();

            Regex pattern = new Regex(@"^(?<start>[a-zA-Z]+)((?:[<|\\]).*?[<|\\])(?<end>[a-zA-Z]+)$");

            if (pattern.IsMatch(keys))
            {
                string start = pattern.Match(keys).Groups["start"].Value;
                string end = pattern.Match(keys).Groups["end"].Value;

                string input = Console.ReadLine();

                string newPattern = @"(?:" + string.Format("{0}", start) + ")" + @"(?<take>.*?)" + @"(?:" + string.Format("{0}", end) + ")";

                Regex newRegex = new Regex(newPattern);

                if (newRegex.IsMatch(input))
                {
                    MatchCollection matches = newRegex.Matches(input);

                    StringBuilder output = new StringBuilder();

                    foreach (Match item in matches)
                    {
                        output.Append(item.Groups["take"].Value);
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
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
