using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

            string str1 = tokens[0];
            string str2 = tokens[1];

            BigInteger result = Multiply(str1, str2);

            Console.WriteLine(result);
        }

        private static BigInteger Multiply(string str1, string str2)
        {
            BigInteger result = 0;
            for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
            {
                result += (BigInteger)str1[i] * (int)str2[i];
            }

            for (int i = Math.Min(str1.Length, str2.Length); i < Math.Max(str1.Length, str2.Length); i++)
            {
                if (str1.Length>str2.Length)
                {
                    result += (int)str1[i];
                }
                else
                {
                    result += (int)str2[i];
                }
            }

                return result;
        }
    }
}
