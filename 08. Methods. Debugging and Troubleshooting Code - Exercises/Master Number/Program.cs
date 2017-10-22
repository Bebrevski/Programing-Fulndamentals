using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());

            for (int i = 0; i < integer; i++)
            {
                bool isPalindrome = CheckForSymmetric(i);
                bool canDivide = ChechForDivisible(i);
                bool containsEven = CheckForEvenDigit(i);

                if (isPalindrome == true && canDivide == true && containsEven == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool CheckForEvenDigit(int integer)
        {
            while (!integer.Equals(0))
            {
                int lastDigit = integer % 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }
                integer /= 10;
            }
            return false;
        }

        private static bool ChechForDivisible(int integer)
        {
            int sum = 0;

            while (!integer.Equals(0))
            {
                int lastDigit = integer % 10;
                sum += lastDigit;

                integer /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool CheckForSymmetric(int integer)
        {
            string intToString = integer.ToString();

            bool isPalindrome = false;
            for (int i = 0; i < intToString.Length / 2; i++)
            {
                if (intToString[i] != intToString[intToString.Length - 1 - i])
                {
                    return false;
                }
            }
            return isPalindrome = true;
        }
    }
}
