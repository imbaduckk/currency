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
        }

        Getter getter;

        private void TodayForm_Load(object sender, EventArgs e)
        {
            getter = new Getter(this);
            getter.LoadDataToday();
        }
    }
}
