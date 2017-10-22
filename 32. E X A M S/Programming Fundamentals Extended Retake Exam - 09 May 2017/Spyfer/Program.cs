using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> record = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            bool found = false;

            while (!found)
            {
                for (int index = 1; index < record.Count - 1; index++)
                {
                    if (record[index].Equals(record[index - 1] + record[index + 1]))
                    {
                        record.RemoveAt(index - 1);
                        record.RemoveAt(index);
                        found = true;
                        break;
                    }
                    else if (record[index].Equals(record[index - 1]) && index.Equals(1))
                    {
                        record.RemoveAt(index - 1);
                        found = true;
                        break;
                    }
                    else if (record[index].Equals(record[index + 1]) && index.Equals(record.Count - 2))
                    {
                        record.RemoveAt(index + 1);
                        found = true;
                        break;
                    }
                }
                if (found == true)
                {
                    found = false;
                    if (record.Count.Equals(2) && record[0].Equals(record[1]))
                    {
                        Console.WriteLine(record[0]);
                        return;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", record));
        }
    }
}
