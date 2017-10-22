using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> record = new Dictionary<string, string>();

            string name = Console.ReadLine();
            string email;

            while (!name.Equals("stop"))
            {
                email = Console.ReadLine();
                if (!record.ContainsKey(name))
                {
                    record.Add(name, string.Empty);
                }
                record[name] = email;

                name = Console.ReadLine();
            }

            foreach (KeyValuePair<string, string> person in record)
            {
                if (person.Value.EndsWith("uk") || person.Value.EndsWith("us"))
                {
                    continue;
                }
                Console.WriteLine("{0} -> {1}", person.Key, person.Value);
            }
        }
    }
}
