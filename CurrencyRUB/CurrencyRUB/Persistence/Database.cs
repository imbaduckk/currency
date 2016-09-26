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

        public decimal TryGetValue(Context cxt, string date, string fromCur, string toCur)
        {
                if (!ContainsRate(cxt, new Rate() { Date = date, FromCurrency = fromCur, ToCurrency = toCur }))
                    DownloadRate(cxt, date, fromCur, toCur);
            
            return cxt.Rates.Select(x=>x).Where(x=> (x.Date==date)&&(x.FromCurrency==fromCur)&&(x.ToCurrency==toCur)).First().Value;
        }

        public int DownloadRate(Context cxt, string date,string fromCur, string toCur)
        {
            int count = 0;
            string url = string.Format("http://api.fixer.io/{0}?base={1}&symbols={2}", date, fromCur, toCur);
            using (var client = new WebClient())
            using (var stream = client.OpenRead(url))
            using (var reader = new StreamReader(stream))
            {
                var jObject = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadLine());
                decimal val = (decimal)(jObject["rates"][toCur]);
                TryAddRate(cxt, new Rate() { Date = date, FromCurrency = fromCur, ToCurrency = toCur, Value = val });
            }

            return count;
        }

        public bool ContainsRate(Context cxt, Rate rate)
        {
            return (cxt.Rates.Select(x => x).Where(x=>(x.Date == rate.Date)
            && (x.FromCurrency == rate.FromCurrency)
            && (x.ToCurrency == rate.ToCurrency))).Count()>0;
        }

        public void TryAddRate(Context cxt, Rate rate)
        {
            if (!ContainsRate(cxt, rate))
            {
                cxt.Rates.Add(rate);
                cxt.SaveChanges();
            }

        }

        public void AddRate(Context cxt, Rate rate)
        {
            cxt.Rates.Add(rate);
            cxt.SaveChanges();
        }

        public void AddRates(Context cxt, IEnumerable<Rate> rates)
        {
                cxt.Rates.AddRange(rates);
                cxt.SaveChanges();
            
        }

        public bool Equals(Rate x, Rate y)
        {
            if ((x.Date == y.Date) && (x.FromCurrency == y.FromCurrency) && (x.ToCurrency == y.ToCurrency))
            {
                return true;
            }
            else { return false; }
        }
    }
}
