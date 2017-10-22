using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
           

            if (0 <= age && age <= 18)
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("12$"); 
                }
                else if (day == "Weekend")
                {
                    Console.WriteLine("15$"); 
                }
                else
                {
                    Console.WriteLine("5$"); 
                }
            }
            else if (18 < age && age <= 64)
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("18$");
                }
                else if (day == "Weekend")
                {
                    Console.WriteLine("20$");
                }
                else
                {
                    Console.WriteLine("12$");
                }
            }
            else if (64 < age && age <= 122)
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (day == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("10$");
                }
            }
            else
            {
                Console.WriteLine("Error!");  
            }
        }
    }
}
