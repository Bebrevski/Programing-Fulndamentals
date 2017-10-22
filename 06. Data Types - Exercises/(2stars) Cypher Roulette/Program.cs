using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2stars__Cypher_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string outputText = String.Empty;
            string wordChecker = String.Empty;
            bool isReversed = false;

            for (int cnt = 1; cnt <= n; cnt++)
            {
                string input = Console.ReadLine();

                if (wordChecker == input)
                {
                    outputText = String.Empty;
                    if (input == "spin")
                    {
                        n++;
                    }
                }
                else
                {
                    if (input == "spin")
                    {
                        isReversed = !isReversed;
                        n++;
                    }
                    else
                    {
                        if (isReversed)
                        {
                            outputText = input + outputText;
                        }
                        else
                        {
                            outputText += input;
                        }
                    }
                }
               
                wordChecker = input;
            }

            Console.WriteLine(outputText);
        }
    }
}
