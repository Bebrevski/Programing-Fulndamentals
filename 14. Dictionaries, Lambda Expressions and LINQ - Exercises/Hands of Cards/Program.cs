namespace Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> record =
                new Dictionary<string, HashSet<string>>();

            string input = Console.ReadLine();

            while (!input.Equals("JOKER"))
            {
                string[] tokens = input
                    .Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string player = tokens[0];

                List<string> cards = tokens[1]
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Distinct()
                    .ToList();

                if (!record.ContainsKey(player))
                {
                    record.Add(player, new HashSet<string>());
                }

                foreach (string card in cards)
                {
                    record[player].Add(card);
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> points =
               new Dictionary<string, int>();

            GetSumOfCards(points, record);

            foreach (KeyValuePair<string, int> player in points)
            {
                Console.WriteLine("{0}: {1}", player.Key, player.Value);
            }
        }

        private static void GetSumOfCards(Dictionary<string, int> points, 
                                          Dictionary<string, HashSet<string>> record)
        {
            int J = 11;     int S = 4;
            int Q = 12;     int H = 3;
            int K = 13;     int D = 2;
            int A = 14;     int C = 1;

            int sumPoints = 0;
            foreach (KeyValuePair<string, HashSet<string>> player in record)
            {
                foreach (string item in player.Value)
                {
                    char firstChar = item[0];

                    int power = firstChar.Equals('1') ? 10
                        : firstChar >= '2' && firstChar <= '9' ? firstChar - '0'
                        : firstChar.Equals('J') ? J
                        : firstChar.Equals('Q') ? Q
                        : firstChar.Equals('K') ? K : A;

                    char type = power.Equals(10) ? item[2] : item[1];

                    int typeToInt = type.Equals('S') ? S
                        : type.Equals('H') ? H
                        : type.Equals('D') ? D : C;

                    sumPoints += power * typeToInt;
                }
                points[player.Key] = sumPoints;

                sumPoints = 0;
            }
        }
    }
}
