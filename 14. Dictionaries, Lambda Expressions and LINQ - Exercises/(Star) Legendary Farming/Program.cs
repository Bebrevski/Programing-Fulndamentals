namespace _Star__Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials["shards"] = 0;
            materials["fragments"] = 0;
            materials["motes"] = 0;

            Dictionary<string, int> junk = new Dictionary<string, int>();

            string input = Console.ReadLine().ToLower();

            Regex patter = new Regex(@"(([0-9]+)(?:\s)([\w-]+))");

            string legendary = string.Empty;

            while (true)
            {
                MatchCollection matches = patter.Matches(input);

                bool found = false;
                foreach (Match match in matches)
                {
                    int quantity = int.Parse(match.Groups[2].Value);
                    string material = match.Groups[3].Value;

                    if (materials.ContainsKey(material))
                    {
                        materials[material] += quantity;
                    }
                    else if (!junk.ContainsKey(material))
                    {
                        junk.Add(material, quantity);
                    }
                    else
                    {
                        junk[material] += quantity;
                    }

                    if ((materials["shards"] >= 250)
                      || materials["fragments"] >= 250
                      || materials["motes"] >= 250)
                    {
                        legendary = material.Equals("shards") ? "Shadowmourne"
                                    : material.Equals("fragments") ? "Valanyr"
                                    : "Dragonwrath";

                        materials[material] -= 250;

                        found = true;

                        break;
                    }
                }

                if (found)
                {
                    break;
                }

                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine("{0} obtained!", legendary);

            foreach (KeyValuePair<string, int> item in
                materials.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1}"
                    , item.Key
                    , item.Value);
            }
            foreach (KeyValuePair<string, int> item in
                junk.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1}"
                   , item.Key
                   , item.Value);
            }
        }
    }
}
