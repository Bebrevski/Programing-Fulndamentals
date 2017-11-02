using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WiningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Regex pattern = new Regex(@"[#]{6,10}|[\^]{6,10}|[@]{6,10}|[$]{6,10}");

            foreach (string item in tokens)
            {
                string input = item;

                if (input.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string first = input.Substring(0, 10);
                string second = input.Substring(10, 10);

                Match firstMatch = pattern.Match(first);
                Match secondMatch = pattern.Match(second);

                if (firstMatch.Success && secondMatch.Success &&
                    firstMatch.Value.First() == secondMatch.Value.First())
                {
                    int count = Math.Min(firstMatch.Length, secondMatch.Length);
                    string jackpot = count == 10 ? " Jackpot!" : string.Empty;
                    Console.WriteLine("ticket \"{0}\" - {1}{2}{3}"
                        , item
                        , count
                        , firstMatch.Value.First()
                        , jackpot);
                }
                else
                {
                    Console.WriteLine("ticket \"{0}\" - no match", item);
                }
            }
        }
    }
}