using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader("CASH RECEIPT", '-');

            PrintBody("Charged to", '_');
            PrintBody("Received by", '_');

            PrintFooter('-', "\u00A9 SoftUni");
        }

        static void PrintHeader(string header, char delimiter)
        {
            Console.WriteLine(header);
            Console.WriteLine(new string(delimiter, 30));
        }
        static void PrintBody(string firstLine, char underLine)
        {
            Console.Write(firstLine);
            Console.WriteLine(new string(underLine, 30 - firstLine.Length));
        }
        static void PrintFooter(char delimiter, string logo)
        {
            Console.WriteLine(new string(delimiter, 30));
            Console.WriteLine(logo);
        }
    }
}
