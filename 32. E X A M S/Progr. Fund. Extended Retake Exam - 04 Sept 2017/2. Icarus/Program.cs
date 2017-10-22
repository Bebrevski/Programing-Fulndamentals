using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int startPosition = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int damage = 1;

            while (!command.Equals("Supernova"))
            {
                string[] tokens = command.Split(' ');

                string direction = tokens[0];
                int steps = int.Parse(tokens[1]);

                if (steps.Equals(0))
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (direction.Equals("left"))
                {
                    int counter = 1;

                    while (counter <= steps)
                    {
                        if (startPosition.Equals(0))
                        {
                            startPosition = sequence.Length;
                            damage++;
                        }
                        startPosition--;
                        sequence[startPosition] -= damage;

                        counter++;
                    }

                }
                else if (direction.Equals("right"))
                {
                    int counter = 1;

                    while (counter <= steps)
                    {
                        if (startPosition.Equals(sequence.Length - 1))
                        {
                            startPosition = -1;
                            damage++;
                        }
                        startPosition++;
                        sequence[startPosition] -= damage;

                        counter++;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
