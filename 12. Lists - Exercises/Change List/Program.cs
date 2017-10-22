using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberSequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (!(input.Equals("Odd") || input.Equals("Even")))
            {
                string[] tokens = input.Split(' ');

                string command = tokens[0];

                if (command.Equals("Delete"))
                {
                    int value = int.Parse(tokens[1]);

                    numberSequence.RemoveAll(x => x.Equals(value));
                }
                else if (command.Equals("Insert"))
                {
                    int element = int.Parse(tokens[1]);
                    int position = int.Parse(tokens[2]);

                    numberSequence.Insert(position, element);
                }

                input = Console.ReadLine();
            }

            if (input.Equals("Odd"))
            {
                Console.WriteLine(string.Join(" ", numberSequence.FindAll(x => x % 2 != 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", numberSequence.FindAll(x => x % 2 == 0)));
            }
        }
    }
}
