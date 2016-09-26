using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;

namespace CurrencyRUB
{
    class Database
    {
        public Database()
        {
            
        }

        public int DownloadRate(string date,string fromCur, string toCur)
        {
            int count = 0;
            string url = string.Format("http://api.fixer.io/{0}?base={1}&symbols={2}", date, fromCur, toCur);
            using (var client = new WebClient())
            using (var stream = client.OpenRead(url))
            using (var reader = new StreamReader(stream))
            {
                var jObject = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadLine());
                Console.WriteLine((string)jObject["rates"][toCur]);
            }

            return count;
        }

        public bool CheckRate(Rate rate)
        {
            using (var cxt = new Context())
            {
                return cxt.Rates.Select(x => x.Equals(rate)).Count() > 0;
            }
        }

        public void TryAddRate(Rate rate)
        {
            using (var cxt = new Context())
            {
                cxt.Rates.Add(rate);
                cxt.SaveChanges();
            }
        }

        public void AddRate(Rate rate)
        {
            using (var cxt = new Context())
            {
                cxt.Rates.Add(rate);
                cxt.SaveChanges();
            }
        }

        public void AddRates(IEnumerable<Rate> rates)
        {
            using (var cxt = new Context())
            {
                cxt.Rates.AddRange(rates);
                cxt.SaveChanges();
            }
        }
    }
}
