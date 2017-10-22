using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());

            long centuries = input;
            long years = centuries * 100;
            long days = (int)((double)years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            decimal milliseconds = seconds * 1000m;
            decimal microseconds = milliseconds * 1000m;
            decimal nanoseconds = microseconds * 1000m;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds"
                , centuries
                , years
                , days
                , hours
                , minutes
                , seconds
                , milliseconds
                , microseconds
                , nanoseconds);
        }
    }
}
