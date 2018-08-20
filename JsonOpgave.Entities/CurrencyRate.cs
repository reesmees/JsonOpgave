using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOpgave.Entities
{
    /// <summary>
    /// Represents the exchange rates of different currencies in relation to USD
    /// </summary>
    public class CurrencyRate
    {
        private string disclaimer;
        private string license;
        private long timestamp;
        private string _base;
        private Dictionary<string, decimal> rates;

        /// <summary>
        /// The exchange rates of different currencies in relation to USD
        /// </summary>
        public Dictionary<string, decimal> Rates
        {
            get { return rates; }
            set { rates = value; }
        }
        /// <summary>
        /// The base currency upon which the exchange rates are based.
        /// Must be set to USD.
        /// </summary>
        public string Base
        {
            get { return _base; }
            set {
                if (value == "USD")
                    _base = value;
                else
                    throw new ArgumentException("Base currency must be USD");
            }
        }

        /// <summary>
        /// Representation of when the data was obtained
        /// </summary>
        public long Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
        /// <summary>
        /// License for the openexchangerate website
        /// </summary>
        public string License
        {
            get { return license; }
            set { license = value; }
        }
        /// <summary>
        /// Disclaimer for the openexchangerates website
        /// </summary>
        public string Disclaimer
        {
            get { return disclaimer; }
            set { disclaimer = value; }
        }



    }
}
