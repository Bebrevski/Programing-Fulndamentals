using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Worm_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"^[A-Z][^\.]*\.$");

            while (!input.Equals("Worm Ipsum"))
            {
                if (pattern.IsMatch(input))
                {
                    Regex wordPattern = new Regex(@"[A-Z]?[a-z0-9A-Z]+");

                    MatchCollection wordCollection = wordPattern.Matches(input);

                    foreach (Match word in wordCollection)
                    {
                        Dictionary<char, int> record = new Dictionary<char, int>();

                        string currentWord = word.ToString();

                        for (int i = 0; i < currentWord.Length; i++)
                        {
                            char currentChar = currentWord[i];

                            if (!record.ContainsKey(currentChar))
                            {
                                record.Add(currentChar, 0);
                            }
                            else
                            {
                                record[currentChar]++;
                            }
                        }

                        record = record.OrderByDescending(x => x.Value)
                            .ToDictionary(x => x.Key, x => x.Value);

                        if (record.Values.Max().Equals(0))
                        {
                            continue;
                        }
                        else
                        {
                            int index = input.IndexOf(currentWord);
                            input = input.Remove(index, currentWord.Length).Insert(index, new string(record.Keys.First(), currentWord.Length));
                        }
                    }
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}


/*
using System;
using System.Linq;
using System.Text.RegularExpressions;

public class WormIpsum
{
    public static void Main()
    {
        var sentenceReg = new Regex(@"^[A-Z][^\.]*\.$");
        var wordsReg = new Regex(@"[^\s,\.]+");

        var inputLine = Console.ReadLine();
        while (!inputLine.Equals("Worm Ipsum"))
        {
            var sentenceMatch = sentenceReg.Match(inputLine);
            if (sentenceMatch.Success)
            {
                var wordsMatches = wordsReg.Matches(inputLine);
                foreach (Match match in wordsMatches)
                {
                    var currentWord = match.Value;
                    if (currentWord.Length != currentWord.Distinct().Count())
                    {
                        var symbol = currentWord.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
                        var newWord = string.Concat(Enumerable.Repeat(symbol, currentWord.Length));
                        inputLine = Regex.Replace(inputLine, currentWord, newWord);

                    }
                }

                Console.WriteLine(inputLine);
            }

            inputLine = Console.ReadLine();
        }
    }
}
*/