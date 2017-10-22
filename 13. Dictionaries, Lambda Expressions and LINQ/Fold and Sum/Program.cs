using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = input.Length / 2 / 2;

            int[] secondNintegers = input.Reverse().Take(k).ToArray();

            int[] firstNintegers = input.Take(k).Reverse().ToArray();

            IEnumerable<int> mergedParts = firstNintegers.Concat(secondNintegers);

            int[] basePart = input.Skip(k).Take(2 * k).ToArray();

            IEnumerable<int> result = mergedParts.Select((x, index) => x + basePart[index]);

            Console.WriteLine(string.Join(" ", result));
        }

    }
}
