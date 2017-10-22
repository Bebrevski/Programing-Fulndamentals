using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var photoSize = double.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0:d4}.jpg", photoNumber);
            Console.WriteLine("Date Taken: {0:d2}/{1:d2}/{2:d4} {3:d2}:{4:d2}", day, month, year, hours, minutes);

            var MBorKB = string.Empty;

            if (photoSize / 1000000 >= 1)
            {
                photoSize = Math.Round(photoSize / 1000000, 1);
                MBorKB = "MB";
            }
            else if (photoSize / 1000 >= 1)
            {
                photoSize = photoSize / 1000;
                MBorKB = "KB";
            }
            else MBorKB = "B";

            Console.WriteLine("Size: {0}{1}", photoSize, MBorKB);


            var orientation = string.Empty;

            if (width > height) orientation = "landscape";
            else if (height > width) orientation = "portrait";
            else orientation = "square";

            Console.WriteLine("Resolution: {0}x{1} ({2}) ", width, height, orientation);
        }
    }
}
