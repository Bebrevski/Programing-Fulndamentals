using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong pictures = ulong.Parse(Console.ReadLine());
            ulong filterTime = ulong.Parse(Console.ReadLine());
            ulong filterFactor = ulong.Parse(Console.ReadLine());
            ulong timeForFilteredPic = ulong.Parse(Console.ReadLine());


            ulong filteredPics = (ulong)Math.Ceiling(pictures * (filterFactor / 100.0));
            ulong totalPics = pictures * filterTime;

            ulong totalTime = filteredPics * (ulong)timeForFilteredPic + totalPics;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine("{0:d\\:hh\\:mm\\:ss}",time);
        }
    }
}
