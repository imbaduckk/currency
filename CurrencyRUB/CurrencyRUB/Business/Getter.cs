using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyRUB
{
    class Getter
    {
        Database db = new Database();
        string todayDate;
        string yesterdayDate;
        TodayForm todayForm;

        public Getter(TodayForm todayForm)
        {
            this.todayForm = todayForm;
            var today = DateTime.Today;
            if (DateTime.Today.Hour < 12)
                today -= TimeSpan.FromDays(1);
            todayDate = today.ToString("yyyy-MM-dd");
            yesterdayDate = (today - TimeSpan.FromDays(1)).ToString("yyyy-MM-dd");
        }

        public void LoadDataToday()
        {
            
            using (Context cxt = new Context())
            {
                decimal USDt = db.TryGetValue(cxt, todayDate, "USD", "RUB");
                decimal EURt = db.TryGetValue(cxt, todayDate, "EUR", "RUB");
                decimal USDyt = db.TryGetValue(cxt, yesterdayDate, "USD", "RUB");
                decimal EURyt = db.TryGetValue(cxt, yesterdayDate, "EUR", "RUB");
                decimal USDdif = USDt - USDyt;
                decimal EURdif = EURt - EURyt;

                todayForm.lblEUR.Text = EURt.ToString();
                todayForm.lblEURdif.Text = EURdif.ToString();
                todayForm.lblUSD.Text = USDt.ToString();
                todayForm.lblUSDdif.Text = USDdif.ToString();
                if (USDdif > 0)
                {
                    todayForm.lblUSDdif.Text = "+" + todayForm.lblUSDdif.Text;
                    todayForm.lblUSDdif.ForeColor = System.Drawing.Color.Green;
                }
                else
                    todayForm.lblUSDdif.ForeColor = System.Drawing.Color.Red;

                if (EURdif > 0)
                {
                    todayForm.lblEURdif.Text = "+" + todayForm.lblEURdif.Text;
                    todayForm.lblEURdif.ForeColor = System.Drawing.Color.Green;
                }
                else
                    todayForm.lblEURdif.ForeColor = System.Drawing.Color.Red;


            }
        }
    }
}
