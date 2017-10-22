using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong firstNumber = ulong.Parse(Console.ReadLine());
            ulong secondNumber = ulong.Parse(Console.ReadLine());

            string typeFirstNumber = byte.MinValue <= firstNumber && firstNumber <= byte.MaxValue ? "byte" :
                                     ushort.MinValue <= firstNumber && firstNumber <= ushort.MaxValue ? "ushort" :
                                     uint.MinValue <= firstNumber && firstNumber <= uint.MaxValue ? "uint" :
                                     ulong.MinValue <= firstNumber && firstNumber <= ulong.MaxValue ? "ulong" : string.Empty;

            string typeSecondNumber = byte.MinValue <= secondNumber && secondNumber <= byte.MaxValue ? "byte" :
                                      ushort.MinValue <= secondNumber && secondNumber <= ushort.MaxValue ? "ushort" :
                                      uint.MinValue <= secondNumber && secondNumber <= uint.MaxValue ? "uint" :
                                      ulong.MinValue <= secondNumber && secondNumber <= ulong.MaxValue ? "ulong" : string.Empty;

            ulong typeMaxValue = Math.Min(firstNumber, secondNumber) <= byte.MaxValue ? byte.MaxValue :
                                 Math.Min(firstNumber, secondNumber) <= ushort.MaxValue ? ushort.MaxValue :
                                 Math.Min(firstNumber, secondNumber) <= uint.MaxValue ? uint.MaxValue :
                                 Math.Min(firstNumber, secondNumber) <= ulong.MaxValue ? ulong.MaxValue : 0;

            double overflow = Math.Round(Math.Max(firstNumber, secondNumber) / (double)typeMaxValue);

            if (firstNumber >= secondNumber)
            {
                Console.WriteLine("bigger type: {0}", typeFirstNumber);
                Console.WriteLine("smaller type: {0}", typeSecondNumber);
                Console.WriteLine("{0} can overflow {1} {2} times", firstNumber, typeSecondNumber, overflow);
            }
            else
            {
                Console.WriteLine("bigger type: {0}", typeSecondNumber);
                Console.WriteLine("smaller type: {0}", typeFirstNumber);
                Console.WriteLine("{0} can overflow {1} {2} times", secondNumber, typeFirstNumber, overflow);
            }
        }
    }
}
