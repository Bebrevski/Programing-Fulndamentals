using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int count = 0;
            int mostFreq = 0;
            int element = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i != arr.Length - 1 && element.Equals(arr[i]))
                {
                    continue;
                }
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i].Equals(arr[j]))
                    {
                        count++;
                    }
                }
                if (count >= mostFreq)
                {
                    mostFreq = count;
                    element = arr[i];
                    count = 0;
                }
                else
                {
                    count = 0;
                }
            }
            Console.WriteLine(element);
        }
    }
}
