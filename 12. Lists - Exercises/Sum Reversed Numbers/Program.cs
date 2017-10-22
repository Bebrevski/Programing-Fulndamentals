using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(' ')
                .ToList();

            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                string newString = ReverseString(input[i]);

                numbers.Add(int.Parse(newString));
            }

            Console.WriteLine(numbers.Sum());
        }

        private static string ReverseString(string p)
        {
            string newString = string.Empty;

            for (int i = p.Length - 1; i >= 0; i--)
            {
                if (p[i].Equals("0"))
                {
                    continue;
                }
                newString += p[i];
            }

            return newString;
        }
    }
}
