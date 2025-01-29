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
    public partial class Girilen_Sayının_Üssünü_bulma : Form
    {
        public Girilen_Sayının_Üssünü_bulma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int taban;
            int us;
            int sonuc = 1;
            taban = Convert.ToInt32(textBox1.Text);
            us = Convert.ToInt32(textBox2.Text);
            for (int i = 1; i <= us; i++)
            {
                sonuc = sonuc * taban;
            }
            label1.Text = taban+" üs ü "+us+" sonucu = "+sonuc;
        }
    }
}
