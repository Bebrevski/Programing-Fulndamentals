using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            bool noMatch = false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array.Contains(array[i] + array[j]))
                    {
                        noMatch = true;

                        Console.WriteLine($"{array[i]} + {array[j]} == {array[i] + array[j]}");
                    }
                }
            }
            if (noMatch.Equals(false))
            {
                Console.WriteLine("No");
            }
        }
    }
}
