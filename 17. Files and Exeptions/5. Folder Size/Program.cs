using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"../../TestFolder");

            double sum = 0L;

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                sum += fileInfo.Length;
            }

            double sizeInMB = sum / (1024 * 1024);

            File.WriteAllText(@"../../output.txt", sizeInMB.ToString());
        }
    }
}
