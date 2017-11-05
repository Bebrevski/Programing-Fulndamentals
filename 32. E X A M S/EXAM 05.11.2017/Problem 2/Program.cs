using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tokens = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (!input.Equals("3:1"))
            {
                string[] commands = input.Split();

                string command = commands[0];

                if (command.Equals("merge"))
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    tokens = MergeList(tokens, startIndex, endIndex);
                }
                else if (command.Equals("divide"))
                {
                    int index = int.Parse(commands[1]);
                    int parts = int.Parse(commands[2]);

                    DevideList(tokens, index, parts);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", tokens));
        }

        private static void DevideList(List<string> tokens, int index, int parts)
        {
            List<string> brokenWord = new List<string>();
            string word = tokens[index];
            tokens.RemoveAt(index);

            if (word.Length % parts == 0)
            {
                int peices = word.Length / parts;
                while (!word.Length.Equals(0))
                {
                    string sub = word.Substring(0, peices);
                    word = word.Substring(peices);
                    brokenWord.Add(sub);
                }

                tokens.InsertRange(index, brokenWord);
            }
            else
            {
                int peices = word.Length / parts;
                while (!word.Length.Equals(word.Length % parts))
                {
                    string sub = word.Substring(0, peices);
                    word = word.Substring(peices);
                    brokenWord.Add(sub);
                }

                brokenWord.Add(word);

                tokens.InsertRange(index, brokenWord);
            }
        }

        private static List<string> MergeList(List<string> tokens, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex < 0)
            {
                endIndex = tokens.Count - 1;
            }
            StringBuilder contatenated = new StringBuilder();
            List<string> current = tokens.Skip(startIndex).Take(endIndex - startIndex + 1).ToList();
            int count = 0;

            if (startIndex > tokens.Count && endIndex > tokens.Count)
            {
                current = tokens;

                foreach (string item in current)
                {
                    contatenated.Append(item);
                    count++;
                }

                tokens.RemoveRange(0, count);
                tokens.Insert(0, contatenated.ToString());
            }
            else
            {

                foreach (string item in current)
                {
                    contatenated.Append(item);
                    count++;
                }

                tokens.RemoveRange(startIndex, count);
                tokens.Insert(startIndex, contatenated.ToString());
            }

            count = 0;

            return tokens;
        }
    }
}
