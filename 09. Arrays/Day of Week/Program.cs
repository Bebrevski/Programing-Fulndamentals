using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = new string[] { 
                "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};

            int n = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(dayOfWeek[n - 1]);
            }
            catch
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
