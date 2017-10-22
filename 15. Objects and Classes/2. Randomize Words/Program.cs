using System;

namespace _2._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int firstWord = rnd.Next(0, input.Length);
                int secondWord = rnd.Next(0, input.Length);

                string temp = input[firstWord];
                input[firstWord] = input[secondWord];
                input[secondWord] = temp;
            }

            Console.WriteLine(string.Join("\n", input));
        }
    }
}
