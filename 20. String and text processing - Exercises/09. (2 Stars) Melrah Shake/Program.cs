using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._2_Stars__Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            int indexOfFirstMatch = indexOfFirstMatch = input.IndexOf(pattern);
            int indexOfLastMatch = indexOfLastMatch = input.LastIndexOf(pattern);
    
            if (indexOfLastMatch.Equals(0))
            {
                Console.WriteLine("No shake.");
                Console.WriteLine(input);
                return;
            }

            while (indexOfFirstMatch != -1 && indexOfLastMatch != -1)
            {
                input = input.Remove(indexOfLastMatch, pattern.Length)
                             .Remove(indexOfFirstMatch, pattern.Length);

                Console.WriteLine("Shaked it.");

                pattern = pattern.Length.Equals(1) ? pattern.Remove(0, 1) : pattern.Remove(pattern.Length / 2, 1);

                if (pattern.Length.Equals(0))
                {
                    break;
                }

                indexOfFirstMatch = input.IndexOf(pattern);
                indexOfLastMatch = input.LastIndexOf(pattern);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}
