using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class QueryMess
{
    static void Main()
    {
        string inputLine = Console.ReadLine();

        while (!inputLine.Equals("END"))
        {
            Regex pairs = new Regex(@"([^&=?]*)=([^&=]*)");
            MatchCollection matches = pairs.Matches(inputLine);

            Dictionary<string, List<string>> record = 
                new Dictionary<string, List<string>>();

            for (int i = 0; i < matches.Count; i++)
            {
                string regex = @"((%20|\+)+)";

                string field = matches[i].Groups[1].Value;
                field = Regex.Replace(field, regex, word => " ").Trim();

                string value = matches[i].Groups[2].Value;
                value = Regex.Replace(value, regex, word => " ").Trim();

                if (!record.ContainsKey(field))
                {
                    List<string> values = new List<string>();
                    values.Add(value);
                    record.Add(field, values);
                }
                else if (record.ContainsKey(field))
                {
                    record[field].Add(value);
                }
            }

            foreach (var pair in record)
            {
                Console.Write("{0}=[{1}]"
                    , pair.Key
                    , string.Join(", ", pair.Value));
            }
            Console.WriteLine();

            inputLine = Console.ReadLine();
        }
    }
}