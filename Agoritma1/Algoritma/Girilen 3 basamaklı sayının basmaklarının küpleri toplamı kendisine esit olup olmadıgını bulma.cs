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
    public partial class Girilen_3_basamaklı_sayının_basmaklarının_küpleri_toplamı_kendisine_esit_olup_olmadıgını_bulma : Form
    {
        public Girilen_3_basamaklı_sayının_basmaklarının_küpleri_toplamı_kendisine_esit_olup_olmadıgını_bulma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int toblam = 0;
            int bas;
            int geçicisayi = sayi;
            while (geçicisayi >0)
            {
                bas = geçicisayi % 10;
                toblam += (bas * bas * bas);
                geçicisayi /= 10;
            }
            if (toblam == sayi)
            {
                label1.Text = "Girilen sayı Eşittir";
            }
            else
            {
                label1.Text = "Girilen sayı Eşit Değildir";
            }
        }
    }
}
