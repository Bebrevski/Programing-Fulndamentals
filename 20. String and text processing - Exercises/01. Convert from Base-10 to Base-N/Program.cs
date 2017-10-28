using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
class Solution
{
    static void Main(String[] args)
    {
        BigInteger[] input = Console.ReadLine()
            .Split()
            .Select(BigInteger.Parse)
            .ToArray();

        BigInteger baseNnumber = input[0];
        BigInteger base10number = input[1];

        BigInteger remain = 0;

        string result = string.Empty;
        if (baseNnumber >= 2 && baseNnumber <= 10)
        {
            while (base10number > 0)
            {
                remain = base10number % baseNnumber;
                base10number /= baseNnumber;
                result = remain.ToString() + result;
            }
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}