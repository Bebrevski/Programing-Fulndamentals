using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
        //Валидно решение е и фор цикъл в мейн метода и в тялото му метода от предходната задача
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            List<int> record = GetPrimeNumbers(num1, num2);

            Console.WriteLine(string.Join(", ", record));
        }

        private static List<int> GetPrimeNumbers(int num1, int num2)
        {
            List<int> record = new List<int>();           

            for (int i = num1; i <= num2; i++)
            {
                bool isPrime = true;
                if (i < 2)
                {
                    continue;
                }
                else if (i == 2 || i == 3 || i == 5 || i == 7)
                {
                    record.Add(i);
                }
                else
                {
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime.Equals(true))
                    {
                        record.Add(i);
                    }
                }
            }

            return record;
        }
    }
}
