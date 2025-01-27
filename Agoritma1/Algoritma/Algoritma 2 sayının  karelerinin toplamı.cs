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
    public partial class Algoritma_2_sayının__karelerinin_toplamı : Form
    {
        public Algoritma_2_sayının__karelerinin_toplamı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sayi1 = Convert.ToInt32(textBox1.Text);
            int Sayi2 = Convert.ToInt32(textBox2.Text);
            int top /*toplam*/;
            top = (Sayi1 * Sayi1) + (Sayi2 * Sayi2);
            label1.Text = "Karelerinin Toplamı="+top;

        }
    }
}
