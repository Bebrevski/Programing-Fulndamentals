using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"(?:^|[ \b])([a-zA-Z0-9]+[._-]?[a-zA-Z0-9]+)@([a-z]+[.-]?[a-z]+)(\.([a-z]+))+");

            if (pattern.IsMatch(input))
            {
                List<string> matches = pattern.Matches(input)
                                              .Cast<Match>()
                                              .Select(a => a.Value)
                                              .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, matches.Select(a => a.TrimEnd('.'))));
            }
        }
    }
}
