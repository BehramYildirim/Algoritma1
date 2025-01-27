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
    public partial class carpma_islemini_toplama_islemi_kullanrak_yapma : Form
    {
        public carpma_islemini_toplama_islemi_kullanrak_yapma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 0;
            int sayi2 = 0;
            int sayac = 0;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            while (sayi2 > 0)
            {
                sayac += sayi1;
                sayi2--;
            }
            label1.Text = "sonuç = " + sayac;
        }
    }
}
