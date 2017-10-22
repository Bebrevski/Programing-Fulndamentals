using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = GetNumberInWord(input);

            Console.WriteLine(output);
        }

        private static string GetNumberInWord(string input)
        {
            int lastDigit = (int)input[input.Length - 1] - '0';

            string[] ToTen = new string[] { 
               "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            return ToTen[lastDigit];
        }
    }
}
