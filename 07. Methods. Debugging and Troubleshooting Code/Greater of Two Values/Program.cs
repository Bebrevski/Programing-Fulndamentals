using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            if (dataType.Equals("int"))
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                int max = GetMax(firstNum, secondNum);
                Console.WriteLine(max);
            }
            else if (dataType.Equals("char"))
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());

                char max = GetMax(firstChar, secondChar);
                Console.WriteLine(max);
            }
            else if (dataType.Equals("string"))
            {
                string firstWord = Console.ReadLine();
                string secondWord = Console.ReadLine();

                string max = GetMax(firstWord, secondWord);
                Console.WriteLine(max);
            }
        }

        private static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static string GetMax(string word1, string word2)
        {
            if (word1.CompareTo(word2) >= 0)
            {
                return word1;
            }
            else
            {
                return word2;
            }
        }
    }
}
