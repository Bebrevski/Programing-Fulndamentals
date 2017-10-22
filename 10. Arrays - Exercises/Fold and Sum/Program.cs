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
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = input.Length / 4;

            int[] firstRow = new int[input.Length / 4];
            for (int i = 0; i < firstRow.Length; i++)
            {
                firstRow[i] = input[i];
            }

            ReverseArray(firstRow);

            int[] secondRow = new int[input.Length / 4];
            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = input[3 * k + i];
            }

            ReverseArray(secondRow);

            int[] middleRow = new int[input.Length / 2];
            for (int i = 0; i < middleRow.Length; i++)
            {
                middleRow[i] = input[k + i];
            }

            for (int i = 0; i < firstRow.Length; i++)
            {
                middleRow[i] += firstRow[i];
            }

            for (int i = 0; i < secondRow.Length; i++)
            {
                middleRow[k + i] += secondRow[i];
            }

            Console.WriteLine(string.Join(" ", middleRow));
        }

        private static void ReverseArray(int[] firstRow)
        {
            for (int i = 0; i < firstRow.Length / 2; i++)
            {
                int temp = firstRow[i];
                firstRow[i] = firstRow[firstRow.Length - 1 - i];
                firstRow[firstRow.Length - 1 - i] = temp;
            }
        }
    }
}
