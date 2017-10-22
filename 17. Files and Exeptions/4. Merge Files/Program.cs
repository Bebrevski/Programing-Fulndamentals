using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader readerOne = new StreamReader("../../input1.txt");
            StreamReader readerTwo = new StreamReader("../../input2.txt");

            StreamWriter writer = new StreamWriter("../../output.txt");
            while (!(readerOne.EndOfStream && readerTwo.EndOfStream))
            {
                string lineFirstFile = readerOne.ReadLine();
                string lineSecondFile = readerTwo.ReadLine();

                writer.WriteLine(lineFirstFile);
                writer.WriteLine(lineSecondFile);
            }
            readerOne.Close();
            readerTwo.Close();
            writer.Close();
        }
    }
}
