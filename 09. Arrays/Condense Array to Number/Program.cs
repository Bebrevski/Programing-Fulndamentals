using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            if (array.Length.Equals(0))
            {
                Console.WriteLine(array[0]);
                return;
            }

            int length = array.Length - 1;
            long[] condenced = new long[length];

            while (!condenced.Length.Equals(1))
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    condenced[i] = array[i] + array[i + 1];
                }

                array = condenced;
                condenced = new long[--length];
            }

            Console.WriteLine(array.Sum());
        }
    }
}
