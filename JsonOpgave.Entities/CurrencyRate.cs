using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOpgave.Entities
{
    public class CurrencyRate
    {
        private string disclaimer;
        private string license;
        private long timestamp;
        private string baseCurrency;
        private Dictionary<string, decimal> rates;

        public Dictionary<string, decimal> Rates
        {
            get { return rates; }
            set { rates = value; }
        }

        public string Base
        {
            get { return baseCurrency; }
            set {
                if (value == "USD")
                    baseCurrency = value;
                else
                    throw new ArgumentException("Base currency must be USD");
            }
        }


        public long Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }

        public string License
        {
            get { return license; }
            set { license = value; }
        }

        public string Disclaimer
        {
            get { return disclaimer; }
            set { disclaimer = value; }
        }



    }
}
