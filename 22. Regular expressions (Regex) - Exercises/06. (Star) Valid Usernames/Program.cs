using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06._Star__Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                              .Split(@" /\()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                              .Select(x => x.Trim())
                              .ToArray();

            List<string> content = new List<string>();

            Regex pattern = new Regex(@"^[a-zA-Z]\w{2,25}$");

            foreach (string username in input)
            {
                if (pattern.IsMatch(username))
                {
                    content.Add(username);
                }
            }

            int maxSum = int.MinValue;
            string firstUser = string.Empty;
            string secondUser = string.Empty;

            for (int i = 0; i < content.Count-1; i++)
            {
                int currentSum = content[i].Length + content[i + 1].Length;

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    firstUser = content[i];
                    secondUser = content[i + 1];
                }
            }
            Console.WriteLine(firstUser + Environment.NewLine + secondUser);
        }
    }
}
