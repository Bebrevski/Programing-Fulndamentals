using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (!input.Equals("print"))
            {
                string[] tokens = input.Split(' ');

                string command = tokens[0];

                if (command.Equals("add"))
                {
                    int index = int.Parse(tokens[1]);
                    int element = int.Parse(tokens[2]);

                    numbers.Insert(index, element);
                }
                else if (command.Equals("addMany"))
                {
                    int index = int.Parse(tokens[1]);

                    List<int> elements = new List<int>();

                    elements.AddRange(tokens
                        .Skip(2)
                        .Take(tokens.Length - 2)
                        .Select(int.Parse));

                    numbers.InsertRange(index, elements);
                }
                else if (command.Equals("contains"))
                {
                    int element = int.Parse(tokens[1]);

                    Console.WriteLine(numbers.IndexOf(element));
                }
                else if (command.Equals("remove"))
                {
                    int index = int.Parse(tokens[1]);

                    numbers.RemoveAt(index);
                }
                else if (command.Equals("shift"))
                {
                    int rotations = int.Parse(tokens[1]);

                    ShiftSequence(numbers, rotations);
                }
                else if (command.Equals("sumPairs"))
                {
                    SumPairs(numbers);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        private static void ShiftSequence(List<int> numbers, int rotations)
        {
            for (int rot = 0; rot < rotations; rot++)
            {
                int temp = numbers[0];

                for (int index = 0; index < numbers.Count - 1; index++)
                {
                    numbers[index] = numbers[index + 1];
                }

                numbers[numbers.Count - 1] = temp;
            }
        }

        private static void SumPairs(List<int> numbers)
        {
            if (numbers.Count % 2 == 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                }
            }
        }
    }
}
