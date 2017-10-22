using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures = int.Parse(Console.ReadLine()); //pcs
            int filterTime = int.Parse(Console.ReadLine()); //sec
            int filterFactor = int.Parse(Console.ReadLine()); //%
            int uploadTime = int.Parse(Console.ReadLine()); //sec

            long filteringTime = pictures * (long)filterTime;
            long goodPictures = (long)Math.Ceiling(pictures * ((double)filterFactor / 100));
            long uploadingTime = goodPictures * (long)uploadTime;

            long totalTime = filteringTime + uploadingTime;

            long seconds = totalTime % 60L;
            long minutes = totalTime / 60 % 60L;
            long hours = totalTime / 3600 % 24L;
            long days = totalTime / (3600 * 24L);

            Console.WriteLine("{0}:{1:d2}:{2:d2}:{3:d2}"
                , days
                , hours
                , minutes
                , seconds);
        }
    }
}
