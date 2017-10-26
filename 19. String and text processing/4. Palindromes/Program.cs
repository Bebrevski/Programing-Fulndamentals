using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ,.!?-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            SortedSet<string> record = new SortedSet<string>();
            foreach (string word in input)
            {
                if (word.Equals(new string(word.Reverse().ToArray())))
                {
                    record.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", record));
        }
    }
}
