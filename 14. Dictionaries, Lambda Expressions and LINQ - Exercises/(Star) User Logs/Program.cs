using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> record =
                new SortedDictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string[] tokens = input.Split(' ');

                string IP = tokens[0].Substring(3, tokens[0].Length - 3);
                string username = tokens[2].Substring(5, tokens[2].Length - 5);

                    if (!record.ContainsKey(username))
                    {
                        record.Add(username, new Dictionary<string, int>());
                    }
                    if (!record[username].ContainsKey(IP))
                    {
                        record[username].Add(IP, 0);
                    }

                    record[username][IP]++;


                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> username in record)
            {
                Console.WriteLine("{0}:", username.Key);

                List<string> output = new List<string>();
                foreach (KeyValuePair<string, int> kvp in username.Value)
                {
                    string firstJoin = string.Join(" => ", kvp.Key, kvp.Value);

                    output.Add(firstJoin);
                }

                Console.WriteLine("{0}.", string.Join(", ", output));
            }
        }
    }
}
