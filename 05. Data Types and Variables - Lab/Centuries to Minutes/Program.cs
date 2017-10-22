using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());

            double tropicalYear = 365.2422;

            int years = century * 100;
            int days = (int)(years * tropicalYear);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes"
                , century
                , years
                , days
                , hours
                , minutes);
        }
    }
}
