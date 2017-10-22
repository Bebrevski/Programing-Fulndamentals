using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int loopNumber = int.Parse(Console.ReadLine());

            string outputText = String.Empty;

            for (int cnt = 1; cnt <= loopNumber; cnt++)
            {
                string inputText = Console.ReadLine();

                outputText += inputText + delimiter;
            }
            int remove = delimiter.Length;
            Console.WriteLine(outputText.Remove(outputText.Length-remove,remove));


            /*
             string delimiter = Console.ReadLine();
                int n = int.Parse(Console.ReadLine());

                string output = string.Empty;
            
                for (int i = 1; i <= n; i++)
                {
                    string currentWord = Console.ReadLine();
                    output += currentWord + delimiter;
                }
                int remove = delimiter.Length;
            Console.WriteLine(output.Remove(output.Length - remove, remove));
             */
        }
    }
}
