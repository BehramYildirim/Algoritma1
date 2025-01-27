using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritma
{
    public partial class Dogum_tarihi_giren_kişinin_yaş_hesaplaması : Form
    {
        public Dogum_tarihi_giren_kişinin_yaş_hesaplaması()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan yıl;
            int yas;
            DateTime dogumtarihi;
            dogumtarihi = Convert.ToDateTime(dateTimePicker1.Text);
            yıl = DateTime.Now.Date.Subtract(dogumtarihi);
            yas = Convert.ToInt32(yıl.TotalDays);
            label1.Text = " Şuan " + yas / 365 + " yaşındasınız";


        }

        private void Dogum_tarihi_giren_kişinin_yaş_hesaplaması_Load(object sender, EventArgs e)
        {
            label2.Text = "Bu günün tarihi:"+DateTime.Now.ToShortDateString();
        }
    }
}
