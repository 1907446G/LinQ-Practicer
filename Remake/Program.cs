using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remake
{
    class Program
    {
        static void Main(string[] args)
        {
            var rawData = System.IO.File.ReadAllText(@"C:\Users\Asus\Desktop\CurrencyRateNone.txt");

            using (var context = new AdventureWorks2017Entities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var json = (JsonConvert.DeserializeObject<List<CurrencyRate>>(rawData));
                var CR = context.CurrencyRates;

                var query = (from b in json
                             join p in CR on b.CurrencyRateID equals p.CurrencyRateID
                             orderby b.ToCurrencyCode
                             group b by b.ToCurrencyCode into FX
                             select new { Source = FX.First(), DestinationCurrency = FX.Key, AverageRate = FX.Average(x => x.AverageRate) });


                var dict = new Dictionary<string, Decimal>();

                foreach (var item in query)
                {
                    dict.Add($"{item.Source.FromCurrencyCode}-{item.DestinationCurrency}", item.AverageRate);
                }


                foreach (var item in dict)
                {
                    Console.Write("Input the country code you want to change to (Example: USD): ");
                    var filterCode = Console.ReadLine();
                    if (item.Key.Contains(filterCode))
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Cannot find the FX code entered. Please try again.");
                        continue;
                    }
                }



                Console.ReadKey();

            }
        }
    }

}
