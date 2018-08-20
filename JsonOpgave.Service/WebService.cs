using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonOpgave.Entities;
using System.Net;

namespace JsonOpgave.Service
{
    /// <summary>
    /// Used to deserialize a JSON object to the CurrencyRate class
    /// </summary>
    public class WebService
    {
        private string url;

        /// <summary>
        /// Constructor for the WebService class
        /// </summary>
        /// <param name="url">The URL of the JSON object to be deserialized</param>
        public WebService(string url)
        {
            Url = url;
        }
        /// <summary>
        /// The URL of the JSON object to be deserialized
        /// </summary>
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
        /// <summary>
        /// Deserializes the JSON object retrieved from the URL into an object of the CurrencyRate type
        /// </summary>
        /// <returns>A CurrencyRate object containing the information of the JSON object</returns>
        public CurrencyRate GetCurrencyRate()
        {
            using(WebClient client = new WebClient()) {
                string jsonString = client.DownloadString($@"{url}");

                CurrencyRate currencyRate = JsonConvert.DeserializeObject<CurrencyRate>(jsonString);

                return currencyRate;
            }
        }
    }
}
