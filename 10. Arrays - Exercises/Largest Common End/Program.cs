using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');

            int index = Math.Min(firstArr.Length, secondArr.Length);

            int leftCounter = 0;
            int rightCounter = 0;

            for (int i = 0; i < index; i++)
            {
                if (firstArr[i].Equals(secondArr[i]))
                {
                    leftCounter++;
                }
                if (firstArr[firstArr.Length - 1 - i].Equals(secondArr[secondArr.Length - 1 - i]))
                {
                    rightCounter++;
                }
            }

            Console.WriteLine(Math.Max(leftCounter, rightCounter));
        }
    }
}
