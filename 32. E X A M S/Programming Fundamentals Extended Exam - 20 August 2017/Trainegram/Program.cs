using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex patter = new Regex(@"^(?<locomotive>\<{1}\[{1}[^a-zA-Z0-9]*\]{1})\.{1}(?<wagons>\.{1}\[{1}[a-zA-Z0-9]*\]{1}\.{1})*$");

            List<string> record = new List<string>();

            while (!input.Equals("Traincode!"))
            {
                if (patter.IsMatch(input))
                {
                    record.Add(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, record));
        }
    }
}
