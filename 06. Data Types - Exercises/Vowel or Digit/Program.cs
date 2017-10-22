using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int digit = 0;
            if (int.TryParse(input, out digit))
            {
                Console.WriteLine("digit");
            }
            else if (input.Length.Equals(1) && 
                (input.Equals("a") || 
                 input.Equals("e") || 
                 input.Equals("o") || 
                 input.Equals("i") || 
                 input.Equals("u")))
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
