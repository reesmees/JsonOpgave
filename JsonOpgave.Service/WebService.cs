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
    public class WebService
    {
        private string url;

        public WebService(string url)
        {
            Url = url;
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

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
