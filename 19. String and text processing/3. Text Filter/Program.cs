using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                 .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string sequence = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                sequence = sequence.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(sequence);
        }
    }
}
