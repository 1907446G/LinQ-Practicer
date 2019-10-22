using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml;

namespace NTUPractice
{
    class Program
    {

        static void Main(string[] args)
        {
            //Adding a comment
            using (var context = new AdventureWorks2017Entities1())
            {
                #region Lazy Loading
                context.Configuration.LazyLoadingEnabled = false;
                #endregion
                using (var reader = new StreamReader(@"C:\Users\Asus\CurrencyRate.csv"))
                {
                    List<CurrencyRate> currencyRates = new List<CurrencyRate>();

                    while (!reader.EndOfStream)
                    {
                        CurrencyRate currency = new CurrencyRate();
                        var rawData = reader.ReadLine();
                        var values = rawData.Split('\t');

                        currency.CurrencyRateID = Int32.Parse(values[0]);
                        currency.CurrencyRateDate = DateTime.Parse(values[1]);
                        currency.FromCurrencyCode = values[2];
                        currency.ToCurrencyCode = values[3];
                        currency.AverageRate = Decimal.Parse(values[4]);
                        currency.EndOfDayRate = Decimal.Parse(values[5]);
                        currency.ModifiedDate = DateTime.Parse(values[6]);

                        currencyRates.Add(currency);
                    }


                    //Prints SourceCountry, Des, and Conv rate (2.5)

                    /*
                    var query = from x in currencyRates
                                select new { SourceCountry = x.FromCurrencyCode, DestinationCountry = x.ToCurrencyCode, ConversionRate = x.AverageRate };
                    foreach (var item in query)
                    {
                        Console.WriteLine(item);
                    }
                    */

                    //Prints based on UserInput (2.6)

                    /*
                    Console.Write("Enter Destination Country Code");
                    var userInput = Console.ReadLine();
                    var askForRate = from x in currencyRates
                                     where x.ToCurrencyCode.Contains(userInput)
                                     select new { SourceCountry = x.FromCurrencyCode, DestinationCountry = x.ToCurrencyCode, ConversionRate = x.AverageRate };
                    foreach (var item in askForRate)
                    {
                        Console.WriteLine(item);
                    }
                    */

                /*Group by Dest Country

                        var groupByDest = from x in currencyRates
                                          group x by x.ToCurrencyCode;

                    foreach (var exchange in groupByDest)
                    {
                        Console.WriteLine(exchange.Key);

                        var average = exchange.Average(p => p.AverageRate);
                        var min = exchange.Min(p => p.AverageRate);
                        var max = exchange.Max(p => p.AverageRate);
                        Console.WriteLine($"Average: {average} Min: {min} Max: {max}");
                    }

                    Console.ReadKey();
                }

                var input = Console.ReadLine();
                */

                //Db Pull: 
                    var people = context.People;
                    var emails = context.EmailAddresses;

                    /*var query = from p in people
                                where p.FirstName.Contains("A")
                                select new { p.FirstName, p.LastName };

                    var emailQ = from e in emails
                                 where e.Person.FirstName.Contains(input)
                                 orderby e.Person.FirstName
                                 select new { FirstName = e.Person.FirstName, LastName = e.Person.LastName, Email = e.EmailAddress1 };*/

                    var JsonQuery = from e in people
                                    where e.FirstName.Contains("Jordan")
                                    select e.PersonCreditCards;


                    var ser = new JavaScriptSerializer();
                    var x = ser.Serialize(JsonQuery);


                    Console.WriteLine(x);


                }


                Console.ReadKey();

            }

        }
    }
}