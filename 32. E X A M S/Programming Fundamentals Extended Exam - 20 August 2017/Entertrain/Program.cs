using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainPower = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            List<int> record = new List<int>();

            while (!input.Equals("All ofboard!"))
            {
                int wagonWeight = int.Parse(input);

                record.Add(wagonWeight);

                if (record.Sum() > trainPower)
                {
                    int average = (int)record.Average();

                    int minDiff = int.MaxValue;
                    int wagonToRemove = 0;
                    for (int i = 0; i < record.Count; i++)
                    {
                        if (Math.Abs(record[i] - average) < minDiff)
                        {
                            minDiff = Math.Abs(record[i] - average);
                            wagonToRemove = record[i];
                        }
                    }
                    record.Remove(wagonToRemove);
                }

                input = Console.ReadLine();
            }

            record.Reverse();

            record.Add(trainPower);

            Console.WriteLine(string.Join(" ", record));
        }
    }
}
