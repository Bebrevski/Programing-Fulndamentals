using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"\b(?:0x)?[0-9A-F]+\b");

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
