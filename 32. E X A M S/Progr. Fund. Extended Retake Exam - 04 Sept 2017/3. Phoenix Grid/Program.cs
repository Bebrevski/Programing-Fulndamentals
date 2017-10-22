using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"^(([^_\s]{3})\.*)+$");

            List<string> record = new List<string>();

            while (!input.Equals("ReadMe"))
            {
                if (pattern.IsMatch(input))
                {
                    string forward = input;

                    StringBuilder backwards = new StringBuilder();

                    for (int i = input.Length-1; i >= 0; i--)
                    {
                        backwards.Append(input[i]);
                    }

                    if (forward.Equals(backwards.ToString()))
                    {
                        record.Add("YES");
                    }
                    else
                    {
                        record.Add("NO");
                    }
                }
                else
                {
                    record.Add("NO");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine,record));
        }
    }
}
