using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQRecap
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using (var context = new AdventureWorks2017Entities())
            {
                Console.Write("Enter a first name: ");
                var firstName = Console.ReadLine();
                var field = context.Passwords;
                var query = (from x in field
                             where x.Person.FirstName.Contains(firstName)
                             select new { FirstName = x.Person.FirstName, PasswordHash = x.PasswordHash});
                foreach (var item in query)
                {
                    Console.WriteLine($"{item.FirstName} - {item.PasswordHash}");
                }
            }*/
           
        }
    }
}
