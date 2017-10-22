using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char operand = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int result = operand == '+' ? firstNumber + secondNumber :
                            operand == '-' ? firstNumber - secondNumber :
                            operand == '*' ? firstNumber * secondNumber :firstNumber / secondNumber;

            Console.WriteLine("{0} {1} {2} = {3}", firstNumber, operand, secondNumber, result);
        }
    }
}
