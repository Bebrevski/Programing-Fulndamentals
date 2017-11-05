using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] values = Console.ReadLine().Split(new[] { '{', '}' },StringSplitOptions.RemoveEmptyEntries);

            Regex pattern = new Regex(@"([a-zA-Z]+)(.*)(\1)");

            MatchCollection matches = pattern.Matches(input);

            StringBuilder output = new StringBuilder();

            int index = 0;
            int nextChange;
            foreach (Match item in matches)
            {
                string start = item.Groups[1].Value;
                string placeholder = item.Groups[2].Value;
                string end = item.Groups[3].Value;

                if (index > values.Length - 1)
                {
                    break;
                }

                nextChange = input.IndexOf(placeholder);

                input = input.Remove(nextChange, placeholder.Length).ToString();
                input = input.Insert(nextChange, values[index]).ToString();

                index++;

                nextChange += 1;
            }
            Console.WriteLine(input);
        }
    }
}
