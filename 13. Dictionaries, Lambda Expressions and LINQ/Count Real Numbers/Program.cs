namespace Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> record = new SortedDictionary<double, int>();

            List<double> nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            foreach (double num in nums)
            {
                if (!record.ContainsKey(num))
                {
                    record.Add(num, 0);
                }
                record[num]++;
            }

            foreach (KeyValuePair<double, int> num in record)
            {
                Console.WriteLine("{0} -> {1}"
                    , num.Key
                    , num.Value);
            }
        }
    }
}
