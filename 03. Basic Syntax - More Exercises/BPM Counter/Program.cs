using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int BPM = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());

            double bars = Math.Round(beats / 4.0, 1);
            int seconds = beats * 60 / BPM;

            int minutes = seconds / 60;
            seconds %= 60;

            Console.WriteLine("{0} bars - {1}m {2}s", bars, minutes, seconds);
        }
    }
}
