using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Take(i).Sum().Equals(arr.Skip(i + 1).Take(arr.Length - i).Sum()))
                {
                    index = i;
                }
            }

            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
