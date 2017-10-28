using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Convert_from_Base_N_to_Base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            int numBase = int.Parse(input[0]);
            string numToConvert = input[1];

            if (numBase >= 2 && numBase <= 10)
            {
                BigInteger result = 0;
                for (int i = 0; i < numToConvert.Length; i++)
                {
                    int lastNum = numToConvert[numToConvert.Length - 1 - i] - '0';

                    result += lastNum * (BigInteger.Pow(numBase, i));
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
