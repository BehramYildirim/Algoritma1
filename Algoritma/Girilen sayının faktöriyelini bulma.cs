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
    public partial class Girilen_sayının_faktöriyelini_bulma : Form
    {
        public Girilen_sayının_faktöriyelini_bulma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            double sayi = Convert.ToInt32(textBox1.Text);
            double faktoriyel = 1;
            while (i <= sayi)
            {
                faktoriyel = faktoriyel * i;
                i++;
            }
            label1.Text = (sayi + " sayısı'nın faktörüyeli = ") + faktoriyel;
        }
    }
}
