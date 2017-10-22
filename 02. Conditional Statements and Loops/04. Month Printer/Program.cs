using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            if (number >= 1 && number <= 12)
            {
                Console.WriteLine(months[number-1]);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
