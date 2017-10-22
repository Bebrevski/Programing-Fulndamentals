using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpyGram
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> people =
                new Dictionary<string, List<string>>();

            string privateKey = Console.ReadLine();
            string line = Console.ReadLine();

            List<int> nums = new List<int>();

            for (int i = 0; i < privateKey.Length; i++)
            {
                nums.Add(int.Parse(privateKey.Substring(i, 1)));
            }

            Regex pattern = new Regex(@"^TO:\s(?<sender>[A-Z]+)\;\sMESSAGE\:\s.+\;$");
            

            while (!line.Equals("END"))
            {
                if (pattern.IsMatch(line))
                {
                    Match senderName = pattern.Match(line);

                    string sender = senderName.Groups[1].ToString();

                    if (!people.ContainsKey(sender))
                    {
                        people.Add(sender, new List<string>());
                    }

                    StringBuilder encrypt = new StringBuilder();
                    int counter = 0;

                    for (int index = 0; index < line.Length; index++)
                    {
                        int currentLetter = line[index] + nums[counter];
                        counter++;

                        char newChar = (char)currentLetter;

                        if (counter.Equals(nums.Count))
                        {
                            counter = 0;
                        }
                        encrypt.Append(newChar);
                    }

                    people[sender].Add(encrypt.ToString());
                }

                line = Console.ReadLine();
            }

            people = people.OrderBy(n => n.Key).ToDictionary(n => n.Key, n => n.Value);

            foreach (KeyValuePair<string,List<string>> name in people)
            {
                foreach (string message in name.Value)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}
