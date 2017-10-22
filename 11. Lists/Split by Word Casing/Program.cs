using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new[] { ' ', ',', ';', ':', '.', '!', '(', ')', '\\', '/', '[', ']', '\'', '\"' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            foreach (string word in input)
            {
                bool isLowerCase;
                bool isUppercase;

                isLowerCase = CheckForLowerCase(word);

                if (!isLowerCase)
                {
                    isUppercase = CheckForUpperCase(word);

                    if (!isUppercase)
                    {
                        mixedCase.Add(word);
                    }
                    else
                    {
                        upperCase.Add(word);
                    }
                }
                else
                {
                    lowerCase.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }

        private static bool CheckForUpperCase(string word)
        {
            bool isUpper = true;

            for (int index = 0; index < word.Length; index++)
            {
                if (word[index] >= 'A' && word[index] <= 'Z')
                {
                    isUpper = true;
                }
                else
                {
                    isUpper = false;
                    break;
                }
            }
            return isUpper;
        }

        private static bool CheckForLowerCase(string word)
        {
            bool isLower = true;

            for (int index = 0; index < word.Length; index++)
            {
                if (word[index] >= 'a' && word[index] <= 'z')
                {
                    isLower = true;
                }
                else
                {
                    isLower = false;
                    break;
                }
            }
            return isLower;
        }
    }
}
