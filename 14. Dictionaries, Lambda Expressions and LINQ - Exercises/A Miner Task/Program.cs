using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> record = new Dictionary<string, long>();

            string input = Console.ReadLine();
            int n = 1;
            string key = string.Empty;

            while (!input.Equals("stop"))
            {
                if (n % 2 != 0)
                {
                    key = input;
                    if (!record.ContainsKey(key))
                    {
                        record.Add(key, 0L);
                    }
                }
                else
                {
                    record[key] += long.Parse(input);
                }

                input = Console.ReadLine();
                n++;
            }

            foreach (KeyValuePair<string, long> line in record)
            {
                Console.WriteLine("{0} -> {1}"
                    , line.Key
                    , line.Value);
            }
        }
    }
}
