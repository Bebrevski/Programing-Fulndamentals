using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());
            int forthtInteger = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:d4} {1:d4} {2:d4} {3:d4}", firstInteger, secondInteger, thirdInteger,forthtInteger); 
        }
    }
}
