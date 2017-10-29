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
            //string number = Console.ReadLine();
            //int multiplier = int.Parse(Console.ReadLine());
            //number = string.Join("", number.Reverse());

            //var result = new StringBuilder();
            //int current = 0;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    int next = 0;
            //    current += (number[i] - 48) * multiplier;
            //    if (current >= 10)
            //    {
            //        next = current / 10;
            //        current %= 10;
            //    }
            //    result.Append(current);
            //    current = next;
            //}
            //if (current != 0)
            //{
            //    result.Append(current.ToString());
            //}
            //string final = string.Join("", result.ToString().TrimEnd('0').Reverse());
            //Console.WriteLine(final.Length != 0 ? final : "0");

            //Solution for multiple digits =>

            StringBuilder number = new StringBuilder(Console.ReadLine());
            StringBuilder multiplier = new StringBuilder(Console.ReadLine());
            if (int.Parse(multiplier.ToString()).Equals(0))
            {
                Console.WriteLine(0);
                return;
            }

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
