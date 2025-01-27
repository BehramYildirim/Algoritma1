using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Algoritma
{
    public partial class Bölme_islemini_cıkartma__islemi_kullanarak_yapma : Form
    {
        public Bölme_islemini_cıkartma__islemi_kullanarak_yapma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
           int bölünen = Convert.ToInt32(textBox1.Text);
          int bölen = Convert.ToInt32(textBox2.Text);
            while (bölünen >= bölen)
            {
                bölünen -= bölen;
                sonuc++;
            }
            label1.Text = ("Kalan = " + bölünen);
            label2.Text = ("Sonuç = "+sonuc);
        }
    }
}
