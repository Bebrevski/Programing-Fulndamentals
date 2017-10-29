using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"\+359([ -])2\1\d{3}\1\d{4}\b");

            if (pattern.IsMatch(input))
            {
                MatchCollection matches = pattern.Matches(input);

                StringBuilder output = new StringBuilder();
                foreach (Match number in matches)
                {
                    output.Append(number + ", ");
                }

                Console.WriteLine(output.ToString().TrimEnd(',',' '));
            }
        }
    }
}
