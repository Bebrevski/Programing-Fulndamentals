using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;

            array = GetSums(array, n, k);

            Console.WriteLine(string.Join(" ", array));
        }

        private static long[] GetSums(long[] array, int n, int k)
        {
            for (int i = 1; i < n; i++)
            {
                int counter = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    array[i] += array[j];
                    counter++;

                    if (counter.Equals(k))
                    {
                        break;
                    }
                }
            }
            return array;
        }
    }
}
