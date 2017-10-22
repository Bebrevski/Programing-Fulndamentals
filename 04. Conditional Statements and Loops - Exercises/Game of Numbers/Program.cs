using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicalNumber = int.Parse(Console.ReadLine());
            var counter = 0;
            var lastCombination = 0;
            var tellMeTheTruth = false;
            var firstNumber = 0;
            var secondNumber = 0;

            for (int i = n; i <= m; i++)
                for (int j = n; j <= m; j++)
                {
                    counter++;
                    if (i + j == magicalNumber)
                    {
                        lastCombination = i + j;
                        firstNumber = i;
                        secondNumber = j;
                        tellMeTheTruth = true;
                    }
                }

            if (tellMeTheTruth==true)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}",firstNumber,secondNumber,magicalNumber);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", counter, magicalNumber);
            }
        }
    }
}
