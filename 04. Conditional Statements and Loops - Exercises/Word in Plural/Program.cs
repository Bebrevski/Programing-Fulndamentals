using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string newWord;

            bool endsWithY = word.EndsWith("y");
            bool endsWithOther = word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z");

            if (endsWithY == true)
            {
                newWord = word.Remove(word.Length - 1, 1);

                Console.WriteLine("{0}ies",newWord);
            }
            else if (endsWithOther==true)
            {
                Console.WriteLine("{0}es",word);
            }
            else
            {
                Console.WriteLine("{0}s",word);
            }
        }
    }
}
