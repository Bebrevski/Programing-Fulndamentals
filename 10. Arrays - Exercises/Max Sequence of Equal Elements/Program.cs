using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int start = 0;
            int counter = 0;
            int max = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].Equals(arr[i + 1]))
                {
                    counter++;
                    if (counter > max)
                    {
                        start = i - counter;
                        max = counter;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = start + 1; i < start + max + 2; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
