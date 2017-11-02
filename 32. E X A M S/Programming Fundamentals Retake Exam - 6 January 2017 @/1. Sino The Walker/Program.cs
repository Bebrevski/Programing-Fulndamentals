using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan time = TimeSpan.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine()) % 86400;
            int seconds = int.Parse(Console.ReadLine()) % 86400;

           int sumStep = step * seconds;
            TimeSpan asdf = TimeSpan.FromSeconds(sumStep);


            TimeSpan timeSum = time + asdf;

            Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}", timeSum);




            // string time = Console.ReadLine();
            //int steps = int.Parse(Console.ReadLine());
            //int secPerStep = int.Parse(Console.ReadLine());

            //long extraSeconds = (long)steps * secPerStep;
            //int[] parts = time.Split(':').Select(int.Parse).ToArray();
            //long totalSecs =
            //    (long)parts[2] +
            //    (long)parts[1] * 60 +
            //    (long)parts[0] * 3600 
            //    + extraSeconds;

            //long sec = totalSecs % 60;
            //totalSecs -= sec;
            //long mins = (totalSecs % 3600)/60;
            //totalSecs -= mins * 60;
            //long hours = totalSecs/3600;
            //hours = hours % 24;

            //var hoursl = hours.ToString().PadLeft(2, '0');
            //var minsl = mins.ToString().PadLeft(2,'0');
            //var secl = sec.ToString().PadLeft(2, '0');

            //Console.WriteLine($"Time Arrival: {hoursl}:{minsl}:{secl}");
            //Console.ReadLine();
        }
    }
}
