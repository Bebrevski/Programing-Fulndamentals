using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] tokens = input
                .Split('|').ToArray();

            List<string> output = new List<string>();

            for (int i = tokens.Length-1; i >= 0; i--)
            {
                output.AddRange(tokens[i]
                    .Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries));
            }
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
