using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = input == "True" ? "Yes" : "No";

            Console.WriteLine(output);
        }
    }
}
