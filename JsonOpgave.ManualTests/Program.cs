using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonOpgave.Entities;
using JsonOpgave.Service;

namespace JsonOpgave.ManualTests
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService webService = new WebService(@"https://openexchangerates.org/api/latest.json?app_id=5694629fba9d46028ee433bc1b63f11f");

            CurrencyRate currencyRate = webService.GetCurrencyRate();

            Console.WriteLine(currencyRate.Rates["DKK"]);
            Console.Read();
        }
    }
}
