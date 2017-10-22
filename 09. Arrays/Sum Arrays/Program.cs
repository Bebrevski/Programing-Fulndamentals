using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] first = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            long[] second = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            long[] output = GetSumOfArrays(first, second);

            Console.WriteLine(string.Join(" ", output));
        }

        private static long[] GetSumOfArrays(long[] first, long[] second)
        {
            long[] sum = new long[Math.Max(first.Length, second.Length)];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = first[i % first.Length] + second[i % second.Length];
            }

            return sum;
        }
    }
}
