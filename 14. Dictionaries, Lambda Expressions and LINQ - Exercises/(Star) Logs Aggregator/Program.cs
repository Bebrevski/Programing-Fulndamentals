using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _Star__Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> userDuration = new Dictionary<string, int>();
            Dictionary<string, List<string>> userIPs = new Dictionary<string, List<string>>();

            Regex pattern = new Regex(@"^([0-9.]+)(?=\s)(?:\s)([a-zA-Z]+)(?:\s)([0-9]+)$");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = pattern.Match(input);

                string username = match.Groups[2].Value;
                int duration = int.Parse(match.Groups[3].Value);
                string IP = match.Groups[1].Value;

                if (!userDuration.ContainsKey(username))
                {
                    userDuration.Add(username, 0);
                    userIPs.Add(username, new List<string>());
                }

                userDuration[username] += duration;
                userIPs[username].Add(IP);
            }

            foreach (KeyValuePair<string, int> user in
                userDuration.OrderBy(u => u.Key))
            {
                Console.WriteLine("{0}: {1} [{2}]"
                    , user.Key
                    , user.Value
                    , string.Join(", ", userIPs[user.Key].Distinct().OrderBy(ips => ips)));
            }
        }
    }
}
