using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" .,:;()[]\"'\\/!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToList();

            Console.WriteLine(string.Join(", ",
                input.OrderBy(x => x).Distinct().Where(x => x.Length < 5)));
        }
    }
}
