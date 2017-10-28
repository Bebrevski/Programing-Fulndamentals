using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder number1 = new StringBuilder(Console.ReadLine());
            StringBuilder number2 = new StringBuilder(Console.ReadLine());

            int zeroes = Math.Max(number1.Length, number2.Length) -
                         Math.Min(number1.Length, number2.Length);

            if (number1.Length > number2.Length)
            {
                number2.Insert(0, new string('0', zeroes));
            }
            else
            {
                number1.Insert(0, new string('0', zeroes));
            }

            StringBuilder result = new StringBuilder();

            int sumOfTwoNumbers = 0;
            int remain = 0;
            for (int i = number1.Length - 1; i >= 0; i--)
            {
                sumOfTwoNumbers = (number1[i] - '0') +
                                  (number2[i] - '0') +
                                  remain;

                if (sumOfTwoNumbers > 9)
                {
                    remain = 1;
                    sumOfTwoNumbers %= 10;
                }
                else
                {
                    remain = 0;
                }
                result.Insert(0, sumOfTwoNumbers);

                if (i.Equals(0) && remain.Equals(1))
                {
                    result.Insert(0, remain);
                }
            }

            Console.WriteLine(result.ToString().TrimStart('0'));
        }
    }
}
