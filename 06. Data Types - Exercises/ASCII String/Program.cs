using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            string outputText = String.Empty;

            for (int cnt = 1; cnt <= inputNumber; cnt++)
            {
                int numberToChar = int.Parse(Console.ReadLine());
                outputText += (char)numberToChar;
            }
            Console.WriteLine(outputText);
        }
    }
}
