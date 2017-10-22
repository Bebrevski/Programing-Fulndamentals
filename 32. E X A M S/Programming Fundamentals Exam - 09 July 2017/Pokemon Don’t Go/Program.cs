using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int sumOfRemovedElements = 0;

            while (!sequence.Count.Equals(0))
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int removedElement = sequence[0];
                    sumOfRemovedElements += removedElement;
                    sequence.RemoveAt(0);
                    sequence.Insert(0, sequence[sequence.Count - 1]);

                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] <= removedElement)
                        {
                            sequence[i] += removedElement;
                        }
                        else if (sequence[i] > removedElement)
                        {
                            sequence[i] -= removedElement;
                        }
                    }
                }
                else if (index >= sequence.Count())
                {
                    int removedElement = sequence[sequence.Count - 1];
                    sumOfRemovedElements += removedElement;
                    sequence.RemoveAt(sequence.Count() - 1);
                    sequence.Add(sequence[0]);

                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] <= removedElement)
                        {
                            sequence[i] += removedElement;
                        }
                        else if (sequence[i] > removedElement)
                        {
                            sequence[i] -= removedElement;
                        }
                    }
                }
                else
                {
                    int removedElement = sequence[index];

                    sumOfRemovedElements += removedElement;
                    sequence.RemoveAt(index);

                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] <= removedElement)
                        {
                            sequence[i] += removedElement;
                        }
                        else if (sequence[i] > removedElement)
                        {
                            sequence[i] -= removedElement;
                        }
                    }
                }
            }
            Console.WriteLine(sumOfRemovedElements);
        }
    }
}
