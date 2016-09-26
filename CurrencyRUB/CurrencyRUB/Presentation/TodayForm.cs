using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyRUB
{
    public partial class TodayForm : Form
    {
        public TodayForm()
        {
            InitializeComponent();

            Database db = new Database();
            db.DownloadRate("2016-09-01", "USD", "RUB");
        }
    }
}
