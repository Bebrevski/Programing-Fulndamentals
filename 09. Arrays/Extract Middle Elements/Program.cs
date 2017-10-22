using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            if (array.Length.Equals(1))
            {
                PrintOneElement(array);
            }
            else if (array.Length % 2 == 0)
            {
                PrintTwoElements(array);
            }
            else if (array.Length % 2 != 0)
            {
                PrintThreeElements(array);
            }
        }

        private static void PrintThreeElements(long[] array)
        {
            List<long> output = new List<long>()
            {
                array[array.Length / 2 - 1],
                array[array.Length / 2],
                array[array.Length / 2 + 1]
            };

            Console.WriteLine("{ " + string.Join(", ", output) + " }");
        }

        private static void PrintTwoElements(long[] array)
        {
            List<long> output = new List<long>(){
                array[array.Length / 2 - 1],
                array[array.Length / 2]
            };

            Console.WriteLine("{ " + string.Join(", ", output) + " }");
        }
        private static void PrintOneElement(long[] array)
        {
            Console.WriteLine(array[0]);
        }

    }
}
