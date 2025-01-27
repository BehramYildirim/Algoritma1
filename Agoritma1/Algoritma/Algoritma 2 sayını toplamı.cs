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
    public partial class Algoritma_2_sayını_toplamı : Form
    {
        public Algoritma_2_sayını_toplamı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      /* B degişkeni ne birinci deger giriliyor*/int sayi1 = Convert.ToInt32(textBox1.Text);
       /* C degişkeni ne ikinci deger giriliyor*/int sayi2 = Convert.ToInt32(textBox2.Text);
        /* A degişkenin de ise başlangıç ve sonuç alınıyor*/int sayi3;
           sayi3 = sayi1 += sayi2;
           // label1.Text = sayi3.ToString(); bilmiyorum belki hata yapmış da olabilirim ama yine burda kalsın 
            label1.Text = "Toplam ="+sayi3;
        }
    }
}