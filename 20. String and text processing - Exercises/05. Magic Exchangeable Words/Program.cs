using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstWord = input[0];
            string secondWord = input[1];

            firstWord = new string(firstWord.Distinct().ToArray());
            secondWord = new string(secondWord.Distinct().ToArray());

            if (firstWord.Length.Equals(secondWord.Length))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
