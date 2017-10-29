using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Weather
    {
        public string City { get; set; }
        public double Temperature { get; set; }
        public string Type { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<type>[a-zA-Z]+)(?=[\|])");

            string input = Console.ReadLine();

            List<Weather> record = new List<Weather>();

            while (!input.Equals("end"))
            {
                if (pattern.IsMatch(input))
                {
                    string city = pattern.Match(input).Groups["city"].Value;
                    double temp = double.Parse(pattern.Match(input).Groups["temp"].Value);
                    string type = pattern.Match(input).Groups["type"].Value;

                    Weather currentWeather = new Weather()
                    {
                        City = city,
                        Temperature = temp,
                        Type = type
                    };

                    if (record.Any(x => x.City.Equals(city)))
                    {
                        //OverwriteData(record,temp,type,city);

                       record.Where(x => x.City.Equals(city)).Select(x => x.Temperature = temp).ToList();
                       record.Where(x => x.City.Equals(city)).Select(x => x.Type = type).ToList();
                    }
                    else
                    {
                        record.Add(currentWeather);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (Weather item in record.OrderBy(x => x.Temperature))
            {
                Console.WriteLine("{0} => {1} => {2}"
                    , item.City
                    , item.Temperature
                    , item.Type);
            }
        }

        //private static void OverwriteData(List<Weather> record, double temp, string type,string city)
        //{
        //    for (int i = 0; i < record.Count; i++)
        //    {
        //        if (record[i].City.Equals(city))
        //        {
        //            record[i].Temperature = temp;
        //            record[i].Type = type;
        //        }
        //    }
        //}
    }
}
