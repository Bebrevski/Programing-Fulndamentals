using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger result = GetFactorial(number);

            int countZeroes = CountZeroes(result);

            Console.WriteLine(countZeroes);
        }

        private static int CountZeroes(BigInteger result)
        {
            int counter = 0;
            BigInteger operationNum = result;

            while (true)
            {
                BigInteger lastDigit = operationNum % 10;

                if (lastDigit.Equals(0))
                {
                    counter++;
                }
                else
                {
                    break;
                }
                operationNum /= 10;
            }
            return counter;
        }

        private static BigInteger GetFactorial(int number)
        {
            BigInteger sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
