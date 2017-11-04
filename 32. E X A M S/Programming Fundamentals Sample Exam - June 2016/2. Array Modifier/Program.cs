using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();

            string input = Console.ReadLine();
            while (!input.Equals("end"))
            {
                string[] tokens = input.Split();

                string command = tokens[0];
                
                if (command.Equals("swap"))
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);
                    SwapElements(arr, firstIndex, secondIndex);
                }
                else if (command.Equals("multiply"))
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);
                    MultiplyElements(arr, firstIndex, secondIndex);
                }
                else if (command.Equals("decrease"))
                {
                    arr = arr.Select(x => x - 1).ToArray();
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",arr));
        }

        private static void MultiplyElements(long[] arr, int firstIndex, int secondIndex)
        {
            arr[firstIndex] *= arr[secondIndex];
        }

        private static void SwapElements(long[] arr, int firstIndex, int secondIndex)
        {
            long temp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
        }
    }
}
