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
            StringBuilder number = new StringBuilder(Console.ReadLine());
            StringBuilder multiplier = new StringBuilder(Console.ReadLine());


            List<StringBuilder> record = new List<StringBuilder>();

            int zeroesCounter = 0;

            for (int m = multiplier.Length - 1; m >= 0; m--)
            {
                StringBuilder currentResult = new StringBuilder();
                int currentMul = 0;
                int remain = 0;

                for (int n = number.Length - 1; n >= 0; n--)
                {
                    currentMul = (multiplier[m] - '0') * (number[n] - '0') + remain;

                    if (currentMul > 9)
                    {
                        remain = currentMul / 10;
                        currentMul %= 10;
                    }
                    else
                    {
                        remain = 0;
                    }

                    currentResult.Insert(0, currentMul);

                    if (n.Equals(0) && remain != 0)
                    {
                        currentResult.Insert(0, remain);
                    }
                }
                currentResult.Append(new string('0', zeroesCounter));
                zeroesCounter++;
                record.Add(currentResult);
            }

            int maxLenght = record.Select(item => item.Length).Max();
            record = record.Select(item => item.Insert(0, new string('0', maxLenght - item.Length))).ToList();

            StringBuilder output = new StringBuilder();

            int index = 1;
            int remainer = 0;
            while (!index.Equals(record[0].Length + 1))
            {
                int charSum = record.Select(item => item[item.Length - index] - '0').ToArray().Sum() + remainer;

                if (charSum > 9)
                {
                    remainer = charSum / 10;
                    charSum %= 10;
                }
                else
                {
                    remainer = 0;
                }

                output.Insert(0, charSum);
                index++;
            }

            Console.WriteLine(output.ToString().TrimStart('0'));
        }
    }
}
