using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int index = 2; index <= num; index++)
            {
                bool isPrime = true;
                for (int diveder = 2; diveder <= Math.Sqrt(index); diveder++)
                {
                    if (index % diveder == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", index, isPrime);
            }

        }
    }
}
