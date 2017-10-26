using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string sequenceToSearch = Console.ReadLine().ToLower();

            int count = 0;
            int index = input.IndexOf(sequenceToSearch);

            while (!index.Equals(-1))
            {
                count++;

                index = input.IndexOf(sequenceToSearch, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
