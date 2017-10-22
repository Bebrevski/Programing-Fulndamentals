using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            bool isPrime = IsPrime(num);

            Console.WriteLine(isPrime);
            
        }

        private static bool IsPrime(long num)
        {
            bool isPrime = true;

            if (num<=1)
            {
                return false;
            }
            else if (num.Equals(2))
            {
                return true;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num%i==0)
                    {
                        isPrime = false;
                        return isPrime;
                    }
                }
                return isPrime;
            }
        }
    }
}
