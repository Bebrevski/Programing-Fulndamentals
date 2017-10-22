using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();

            int rotateTimes = int.Parse(Console.ReadLine());

            int[] record = new int[arr.Length];

            for (int i = 0; i < rotateTimes; i++)
            {
                int temp = arr[arr.Length - 1];
                for (int j = arr.Length - 1; j > 0; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[0] = temp;

                for (int k = 0; k < arr.Length; k++)
                {
                    record[k] += arr[k];
                }
            }
            Console.WriteLine(string.Join(" ", record));
        }
    }
}
