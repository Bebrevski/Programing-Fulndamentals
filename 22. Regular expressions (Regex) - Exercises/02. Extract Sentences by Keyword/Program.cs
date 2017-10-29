using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = string.Format(@"(?<=([ ]))" + @"{0}" + @"(?=([ ]))", Console.ReadLine());

            string withRegex = ".!?";

            string[] input = Console.ReadLine()
                .Split(withRegex.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>x.Trim())
                .ToArray();

            foreach (string sentence in input)
            {
                if (Regex.IsMatch(sentence,regex))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
