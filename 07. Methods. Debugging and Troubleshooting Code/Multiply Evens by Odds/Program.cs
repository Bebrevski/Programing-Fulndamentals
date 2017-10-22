using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetProduct(number);

            Console.WriteLine(result);
        }

        private static int GetProduct(int number)
        {
            int sumEven = 0;
            int sumOdd = 0;

            while (!number.Equals(0))
            {
                int currentNum = number % 10;
                if (currentNum % 2 == 0)
                {
                    sumEven += currentNum;
                }
                else
                {
                    sumOdd += currentNum;
                }

                number /= 10;
            }

            return sumEven * sumOdd;
        }
    }
}
