using Newtonsoft.Json;
using System;
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
                             select new { Old = b.CurrencyRateID, New = p.CurrencyRateID });
                
                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            }
        }
    }

}
