using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");

            if (pattern.IsMatch(input))
            {
                MatchCollection matches = pattern.Matches(input);

                foreach (Match date in matches)
                {
                    string day = date.Groups["day"].Value;
                    string month = date.Groups["month"].Value;
                    string year = date.Groups["year"].Value;

                    Console.WriteLine("Day: {0}, Month: {1}, Year: {2}"
                        , day
                        , month
                        , year);
                }
            }
        }
    }
}
