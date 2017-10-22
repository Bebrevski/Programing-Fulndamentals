using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfPeople = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            var priceForHall = 0.0;
            var priceForPackage = 0.0;
            var discount = 0.0;
            var sum = 0.0;
            var hall = string.Empty;

             if (0 <= countOfPeople && countOfPeople <= 50)
             {
                 hall = "Small Hall";
                 priceForHall = 2500;

                 if (package == "Normal")
                 {
                     priceForPackage = 500;
                     discount = 0.95;
                 }
                 if (package == "Gold")
                 {
                     priceForPackage = 750;
                     discount = 0.9;
                 }
                 if (package == "Platinum")
                 {
                     priceForPackage = 1000;
                     discount = 0.85;
                 }
             }
             else if (50 < countOfPeople && countOfPeople <= 100)
             {
                 hall = "Terrace";
                 priceForHall = 5000;

                 if (package == "Normal")
                 {
                     priceForPackage = 500;
                     discount = 0.95;
                 }
                 if (package == "Gold")
                 {
                     priceForPackage = 750;
                     discount = 0.9;
                 }
                 if (package == "Platinum")
                 {
                     priceForPackage = 1000;
                     discount = 0.85;
                 }
             }
             else if (100 < countOfPeople && countOfPeople <= 120)
             {
                 hall = "Great Hall";
                 priceForHall = 7500;

                 if (package == "Normal")
                 {
                     priceForPackage = 500;
                     discount = 0.95;
                 }
                 if (package == "Gold")
                 {
                     priceForPackage = 750;
                     discount = 0.9;
                 }
                 if (package == "Platinum")
                 {
                     priceForPackage = 1000;
                     discount = 0.85;
                 }
             }
             else if (countOfPeople > 120)
             {
                 Console.WriteLine("We do not have an appropriate hall."); return;
             }

             sum = (priceForHall + priceForPackage) * discount;
             Console.WriteLine("We can offer you the {0}",hall);
             Console.WriteLine("The price per person is {0:f2}$",sum/countOfPeople);

           // if (0 <= countOfPeople && countOfPeople <= 50)
           // {
           //     if (package == "Normal")
           //     {
           //         Console.WriteLine("We can offer you the Small Hall");
           //         Console.WriteLine("The priceForHall per person is {0:f2}$", ((2500 + 500) * 0.95) / countOfPeople);
           //     }
           //     if (package == "Gold")
           //     {
           //         Console.WriteLine("We can offer you the Small Hall");
           //         Console.WriteLine("The priceForHall per person is {0:f2}$", ((2500 + 750) * 0.9) / countOfPeople);
           //     }
           //     if (package == "Platinum")
           //     {
           //         Console.WriteLine("We can offer you the Small Hall");
           //         Console.WriteLine("The priceForHall per person is {0:f2}$", ((2500 + 1000) * 0.85) / countOfPeople);
           //     }
           // }
           // else if (50 < countOfPeople && countOfPeople <= 100)
           // {
           //     if (package == "Normal")
           //     {
           //         Console.WriteLine("We can offer you the Terrace");
           //         Console.WriteLine("The priceForHall per person is {0:f2}$", ((5000 + 500) * 0.95) / countOfPeople);
           //     }
           //     if (package == "Gold")
           //     {
           //         Console.WriteLine("We can offer you the Terrace");
           //         Console.WriteLine("The priceForHall per person is {0:f2}$", ((5000 + 750) * 0.9) / countOfPeople);
           //     }
           //     if (package == "Platinum")
           //     {
           //         Console.WriteLine("We can offer you the Terrace");
           //         Console.WriteLine("The priceForHall per person is {0:f2}$", ((5000 + 1000) * 0.85) / countOfPeople);
           //     }
           // }
           // else if (100 < countOfPeople && countOfPeople <= 120)
           // {
           //     if (package == "Normal")
           //     {
           //         Console.WriteLine("We can offer you the Great Hall");
           //         Console.WriteLine("The priceForHall per person is {0:f2}$", ((7500 + 500) * 0.95) / countOfPeople);
           //     }
           //     if (package == "Gold")
           //     {
           //         Console.WriteLine("We can offer you the Great Hall");
           //         Console.WriteLine("The priceForHall per person is {0:f2}$", ((7500 + 750) * 0.9) / countOfPeople);
           //     }
           //     if (package == "Platinum")
           //     {
           //         Console.WriteLine("We can offer you the Great Hall");
           //         Console.WriteLine("The priceForHall per person is {0:f2}$", ((7500 + 1000) * 0.85) / countOfPeople);
           //     }
           // }
           // else if (countOfPeople > 120)
           // {
           //     Console.WriteLine("We do not have an appropriate hall.");
           // }
        }
    }
}
