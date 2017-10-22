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

            Console.WriteLine(result);
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
