using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int key = int.Parse(Console.ReadLine());

        List<string> outputSites = new List<string>();

        decimal sum = 0m;
        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(new[] { ' ', '\t', '\r' },StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();

            string site = tokens[0];
            long sideVisits = long.Parse(tokens[1]);
            decimal price = decimal.Parse(tokens[2]);

            outputSites.Add(site);

            sum += (decimal)sideVisits * (decimal)price;
        }

        Console.WriteLine(string.Join(Environment.NewLine, outputSites));
        Console.WriteLine("Total Loss: {0:f20}", sum);
        Console.WriteLine("Security Token: {0}", BigInteger.Pow(key, outputSites.Count()));
    }
}

