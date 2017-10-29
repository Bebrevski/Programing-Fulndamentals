using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"(^|(?<=\s))-?\d+(.?\d+)?($|(?=\s))");

            if (pattern.IsMatch(input))
            {
                List<string> record = pattern.Matches(input)
                    .Cast<Match>()
                    .Select(a => a.Value)
                    .ToList();

                Console.WriteLine(string.Join(" ",record));
            }
        }
    }
}
