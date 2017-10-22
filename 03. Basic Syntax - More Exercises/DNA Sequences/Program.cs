using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (var i = 1; i <= 4; i++)
            {
                for (var k = 1; k <= 4; k++)
                {
                    for (var l = 1; l <= 4; l++)
                    {
                        var preSufix = n > i + k + l ? "X" : "O";
                        var firstChar = i == 1 ? "A" : i == 2 ? "C" : i == 3 ? "G" : "T";
                        var secondChar = k == 1 ? "A" : k == 2 ? "C" : k == 3 ? "G" : "T";
                        var thirdChar = l == 1 ? "A" : l == 2 ? "C" : l == 3 ? "G" : "T";

                        if (l > 1)
                            Console.Write(" ");

                        Console.Write(preSufix + firstChar + secondChar + thirdChar + preSufix);
                    }
                    Console.WriteLine();
                }
            }


            /*
             var matchSum = int.Parse(Console.ReadLine());
            var checkSum = 0;
            var rowCount = 0;
            var str = string.Empty;
           
            Char[] nucleicAcid = {'A', 'C', 'G', 'T'};
            int[] nucleicAcidValue = { 1, 2, 3, 4 };
 
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        //var str = "" + nucleicAcid[i] + nucleicAcid[j] + nucleicAcid[k] + " ";
                        //Console.Write(str);
                        checkSum = nucleicAcidValue[i] + nucleicAcidValue[j] + nucleicAcidValue[k];
 
                        if (checkSum >= matchSum)
                        {
                            str = "O" + nucleicAcid[i] + nucleicAcid[j] + nucleicAcid[k] + "O" + " ";
                        }
                        else
                        {
                            str = "X" + nucleicAcid[i] + nucleicAcid[j] + nucleicAcid[k] + "X" + " ";
                        }
                        Console.Write(str);
                        rowCount++;
                        if (rowCount >= 4)
                        {
                            Console.WriteLine();
                            rowCount = 0;
                        }                            
                    }
                }
             * /

           
            
            /*
             int sum = int.Parse(Console.ReadLine());
            int count = 0;
 
            for (int firstDig = 1; firstDig <= 4; firstDig++)
            {
                for (int secondDig = 1; secondDig <= 4; secondDig++)
                {
                    for (int thirdDig = 1; thirdDig <= 4; thirdDig++)
                    {
                        count++;
 
                        if ((firstDig + secondDig + thirdDig) >= sum)
                        {
                            Console.Write("O" + ("" + firstDig + secondDig + thirdDig).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "O ");
 
                        }
                        else
                        {
                            Console.Write("X" + ("" + firstDig + secondDig + thirdDig).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "X ");
                        }
 
                        if (count % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
             * /
            
              
              

            /*
            int matchSum = int.Parse(Console.ReadLine());

            int currentSum = 0;
            int counter = 0;

            for (char i = 'A'; i <= 'T'; i++)
                for (char j = 'A'; j <= 'T'; j++)
                    for (char k = 'A'; k <= 'T'; k++)
                    {
                        currentSum = 0;

                        if      (i.Equals('A')) currentSum += 1;
                        else if (i.Equals('C')) currentSum += 2;
                        else if (i.Equals('G')) currentSum += 3;
                        else if (i.Equals('T')) currentSum += 4;
                        else continue;

                        if      (j.Equals('A')) currentSum += 1;
                        else if (j.Equals('C')) currentSum += 2;
                        else if (j.Equals('G')) currentSum += 3;
                        else if (j.Equals('T')) currentSum += 4;
                        else continue;

                        if      (k.Equals('A')) currentSum += 1;
                        else if (k.Equals('C')) currentSum += 2;
                        else if (k.Equals('G')) currentSum += 3;
                        else if (k.Equals('T')) currentSum += 4;
                        else continue;

                        if (currentSum >= matchSum) Console.Write("O{0}{1}{2}O ", i, j, k);
                        else Console.Write("X{0}{1}{2}X ", i, j, k);

                        counter++;

                        if (counter == 4)
                        {
                            Console.WriteLine();
                            counter = 0;
                        }
                    }
              */
        }
    }
}
