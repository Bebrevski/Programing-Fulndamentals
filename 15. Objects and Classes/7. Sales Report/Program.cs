using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Sales_Report
{
    class Sale
    {
        public string City { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Dictionary<string, double> record = new Dictionary<string, double>();

            for (int i = 0; i < input; i++)
            {
                string[] line = Console.ReadLine().Split();

                Sale current = new Sale()
                {
                    City = line[0],
                    Product = line[1],
                    Price = double.Parse(line[2]),
                    Quantity = double.Parse(line[3])
                };

                if (!record.ContainsKey(current.City))
                {
                    record.Add(current.City, 0);
                }

                record[current.City] += current.Price * current.Quantity;
            }


            foreach (KeyValuePair<string, double> sale in record.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:f2}");
            }
        }
    }
}
